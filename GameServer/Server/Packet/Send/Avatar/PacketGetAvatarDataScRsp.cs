using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Avatar;

public class PacketGetAvatarDataScRsp : BasePacket
{
	public PacketGetAvatarDataScRsp(PlayerInstance player)
		: base(310)
	{
		GetAvatarDataScRsp proto = new GetAvatarDataScRsp
		{
			IsGetAll = true,
			PlayerOutfitData = player.Data.ToPlayerOutfitProto()
		};
		player.PlayerUnlockData.Skins.Values.ToList().ForEach(delegate(List<int> skin)
		{
			proto.SkinList.AddRange(skin.Select((int x) => (uint)x));
		});
		HashSet<uint> hashSet = new HashSet<uint>();
		foreach (FormalAvatarInfo item in player.AvatarManager?.AvatarData?.FormalAvatars ?? Enumerable.Empty<FormalAvatarInfo>())
		{
			proto.AvatarList.Add(item.ToProto());
			List<AvatarPathData> list = item.ToAvatarPathDataProto();
			proto.AvatarPathDataInfoList.AddRange(list);
			foreach (AvatarPathData item2 in list)
			{
				if (GameData.MultiplePathAvatarConfigData.ContainsKey((int)item2.AvatarId))
				{
					hashSet.Add(item2.AvatarId);
				}
			}
		}
		proto.BasicTypeIdList.AddRange(hashSet);
		SetData(proto);
	}
}
