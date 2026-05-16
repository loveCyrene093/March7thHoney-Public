using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketSetGameplayBirthdayScRsp : BasePacket
{
	public PacketSetGameplayBirthdayScRsp(uint birthday)
		: base(24)
	{
		SetGameplayBirthdayScRsp data = new SetGameplayBirthdayScRsp
		{
			Birthday = birthday
		};
		SetData(data);
	}

	public PacketSetGameplayBirthdayScRsp()
		: base(24)
	{
		SetGameplayBirthdayScRsp data = new SetGameplayBirthdayScRsp
		{
			Retcode = 1u
		};
		SetData(data);
	}
}
