using System.Threading.Tasks;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Challenge;
using March7thHoney.Database.Friend;
using March7thHoney.GameServer.Server.Packet.Send.Friend;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Friend;

[Opcode(2929)]
public class HandlerGetFriendBattleRecordDetailCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		uint uid = GetFriendBattleRecordDetailCsReq.Parser.ParseFrom(data).Uid;
		FriendRecordData instance = DatabaseHelper.Instance.GetInstance<FriendRecordData>((int)uid);
		ChallengeData instance2 = DatabaseHelper.Instance.GetInstance<ChallengeData>((int)uid);
		AvatarData instance3 = DatabaseHelper.Instance.GetInstance<AvatarData>((int)uid);
		if (instance == null || instance2 == null || instance3 == null)
		{
			await connection.SendPacket(new PacketGetFriendBattleRecordDetailScRsp(Retcode.RetFriendPlayerNotFound));
		}
		else
		{
			await connection.SendPacket(new PacketGetFriendBattleRecordDetailScRsp(instance, instance2, instance3));
		}
	}
}
