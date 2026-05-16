using March7thHoney.Database.Avatar;
using March7thHoney.Database.Challenge;
using March7thHoney.Database.Friend;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Friend;

public class PacketGetFriendBattleRecordDetailScRsp : BasePacket
{
	public PacketGetFriendBattleRecordDetailScRsp(FriendRecordData recordData, ChallengeData challengeData, AvatarData avatarData)
		: base(2912)
	{
		GetFriendBattleRecordDetailScRsp data = new GetFriendBattleRecordDetailScRsp
		{
			Uid = (uint)recordData.Uid
		};
		SetData(data);
	}

	public PacketGetFriendBattleRecordDetailScRsp(Retcode code)
		: base(2912)
	{
		GetFriendBattleRecordDetailScRsp data = new GetFriendBattleRecordDetailScRsp
		{
			Retcode = (uint)code
		};
		SetData(data);
	}
}
