using System.Linq;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.PlayerBoard;

public class PacketGetPlayerBoardDataScRsp : BasePacket
{
	public PacketGetPlayerBoardDataScRsp(PlayerInstance player)
		: base(2810)
	{
		GetPlayerBoardDataScRsp proto = new GetPlayerBoardDataScRsp
		{
			Signature = player.Data.Signature,
			CurrentHeadIconId = (uint)player.Data.HeadIcon,
			CurrentPersonalCardId = (uint)player.Data.PersonalCard,
			UnlockedPersonalCardList = { player.PlayerUnlockData.PersonalCards.Select((int x) => (uint)x) },
			UnlockedHeadIconList = { player.PlayerUnlockData.HeadIcons.Select((int x) => new HeadIconData
			{
				Id = (uint)x
			}) },
			AssistAvatarIdList = { player.AvatarManager.AvatarData.AssistAvatars.Select((int x) => (uint)x) },
			DisplayAvatarVec = new DisplayAvatarVec(),
			HeadFrameInfo = player.Data.HeadFrame.ToProto()
		};
		int pos = 0;
		player.AvatarManager?.AvatarData.DisplayAvatars.ForEach(delegate(int avatar)
		{
			proto.DisplayAvatarVec.DisplayAvatarList.Add(new DisplayAvatarData
			{
				AvatarId = (uint)avatar,
				Pos = (uint)pos++
			});
		});
		SetData(proto);
	}
}
