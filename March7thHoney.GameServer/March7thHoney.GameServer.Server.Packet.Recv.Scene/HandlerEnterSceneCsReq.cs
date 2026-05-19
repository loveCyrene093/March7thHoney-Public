using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.TrainCakeCatch;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.GameServer.Server.Packet.Send.TrainParty;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.Scene;

[Opcode(1462)]
public class HandlerEnterSceneCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		EnterSceneCsReq req = EnterSceneCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		int storyLineId = (int)(req.SceneIdentifier?.GameStoryLineId ?? 0);
		uint valueOrDefault = (req.SceneIdentifier?.TeleportInfo?.TeleportId).GetValueOrDefault();
		int valueOrDefault2 = (int)(req.SceneIdentifier?.TeleportInfo?.Reason).GetValueOrDefault();
		uint roomOwnerUid = ((valueOrDefault != 0) ? ResolveRoomOwnerUid(player.Uid, valueOrDefault) : 0u);
		bool flag = roomOwnerUid != 0;
		if (flag)
		{
			bool flag2 = (uint)(valueOrDefault2 - 2) <= 3u;
			flag = flag2;
		}
		bool isSocialPlayEnter = flag;
		bool isOwnerSocialEnter = isSocialPlayEnter && roomOwnerUid == (uint)player.Uid;
		bool isJoinedSocialEnter = isSocialPlayEnter && roomOwnerUid != (uint)player.Uid;
		uint? num = player.TrainCakeCatchManager?.CurrentRoomOwnerUid;
		TrainCakeCatchManager.SocialPlaySceneContext socialPlaySceneContext = ((!isSocialPlayEnter) ? null : player.TrainCakeCatchManager?.GetRoomSceneContext(roomOwnerUid));
		if ((player.TrainCakeCatchManager?.CurrentRoomOwnerUid.HasValue ?? false) && (req.SceneIdentifier?.TeleportInfo == null || req.SceneIdentifier.TeleportInfo.TeleportId == 0))
		{
			await connection.SendPacket(new PacketEnterSceneScRsp(await player.TrainCakeCatchManager.ReturnToBookedSceneAsync(sendPacket: true), req.IsCloseMap, storyLineId, (uint)player.Data.FloorId));
			return;
		}
		int teleportId = (int)((req.TeleportId != 0) ? req.TeleportId : 0);
		int sceneEntryId = (int)req.EntryId;
		if (isSocialPlayEnter)
		{
			player.TrainCakeCatchManager.PrepareSocialPlayRoom(roomOwnerUid);
			teleportId = 0;
			if (socialPlaySceneContext != null)
			{
				sceneEntryId = socialPlaySceneContext.EntryId;
			}
			if (num.HasValue && num.Value != roomOwnerUid)
			{
				BasePacket basePacket = new BasePacket(9662);
				basePacket.SetData(new SocialPlayGameplayOperationScNotify
				{
					MFBDMLPDEOE = num.Value,
					NCFHGIBCEBG = (uint)player.Uid,
					NEAIFLAADFE = (uint)player.Uid
				});
				await connection.SendPacket(basePacket);
			}
			if (isJoinedSocialEnter)
			{
				BasePacket basePacket2 = new BasePacket(9662);
				basePacket2.SetData(new SocialPlayGameplayOperationScNotify
				{
					MFBDMLPDEOE = roomOwnerUid,
					NCFHGIBCEBG = (uint)player.Uid,
					PAIBKOMPFOE = player.TrainCakeCatchManager.GetGameplayType(roomOwnerUid, (uint)player.Uid)
				});
				await connection.SendPacket(basePacket2);
			}
			else if (isOwnerSocialEnter)
			{
				SocialPlayGameplayOperationScNotify socialPlayGameplayOperationScNotify = player.TrainCakeCatchManager.BuildArrivalHistoryNotify(roomOwnerUid);
				if (socialPlayGameplayOperationScNotify != null)
				{
					BasePacket basePacket3 = new BasePacket(9662);
					basePacket3.SetData(socialPlayGameplayOperationScNotify);
					await connection.SendPacket(basePacket3);
				}
			}
			await connection.SendPacket(new PacketTrainPartyBuildRoomScNotify(player));
		}
		await connection.SendPacket(new PacketEnterSceneScRsp(await player.EnterScene(sceneEntryId, teleportId, sendPacket: true, storyLineId, req.IsCloseMap), req.IsCloseMap, storyLineId, (uint)player.Data.FloorId, isSocialPlayEnter ? roomOwnerUid : 0u));
		if (!isSocialPlayEnter)
		{
			return;
		}
		MKHIPFHEKCK mKHIPFHEKCK = ((!isOwnerSocialEnter) ? (await player.TrainCakeCatchManager.EnterSocialPlayRoomAsync(roomOwnerUid)) : (await player.TrainCakeCatchManager.AttachToSocialPlayRoomAsync(roomOwnerUid)));
		MKHIPFHEKCK iNPEGNFEPAP = mKHIPFHEKCK;
		BasePacket basePacket4 = new BasePacket(9662);
		basePacket4.SetData(new SocialPlayGameplayOperationScNotify
		{
			MFBDMLPDEOE = roomOwnerUid,
			NCFHGIBCEBG = (uint)player.Uid,
			INPEGNFEPAP = iNPEGNFEPAP
		});
		player.TrainCakeCatchManager.UpdateCurrentRoomSceneContext();
		await connection.SendPacket(basePacket4);
		if (isOwnerSocialEnter)
		{
			await player.TrainCakeCatchManager.BroadcastRoomSnapshotAsync();
		}
		foreach (SocialPlayRoomPlayerMoveScNotify item in player.TrainCakeCatchManager.BuildInitialRoomMoveNotifies(roomOwnerUid))
		{
			BasePacket basePacket5 = new BasePacket(9621);
			basePacket5.SetData(item);
			await connection.SendPacket(basePacket5);
		}
	}

	private static uint ResolveRoomOwnerUid(int playerUid, uint teleportId)
	{
		if (teleportId == 0)
		{
			return (uint)playerUid;
		}
		uint uid = (uint)ConfigManager.Config.ServerOption.ServerProfile.Uid;
		if (teleportId == uid)
		{
			return (uint)playerUid;
		}
		return teleportId;
	}
}
