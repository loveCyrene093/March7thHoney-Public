using March7thHoney.Database.Avatar;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Lineup;

public class PacketGetLineupAvatarDataScRsp : BasePacket
{
	public PacketGetLineupAvatarDataScRsp(PlayerInstance player)
		: base(774)
	{
		GetLineupAvatarDataScRsp rsp = new GetLineupAvatarDataScRsp();
		player.AvatarManager?.AvatarData?.FormalAvatars?.ForEach(delegate(FormalAvatarInfo avatar)
		{
			LineupAvatarData item = new LineupAvatarData
			{
				Id = (uint)avatar.AvatarId,
				Hp = (uint)avatar.CurrentHp,
				AvatarType = AvatarType.AvatarFormalType
			};
			rsp.AvatarDataList.Add(item);
		});
		SetData(rsp);
	}
}
