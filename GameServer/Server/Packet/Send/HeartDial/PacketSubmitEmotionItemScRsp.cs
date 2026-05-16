using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.HeartDial;

public class PacketSubmitEmotionItemScRsp : BasePacket
{
	public PacketSubmitEmotionItemScRsp(uint scriptId)
		: base(6318)
	{
		SubmitEmotionItemScRsp data = new SubmitEmotionItemScRsp
		{
			ScriptId = scriptId
		};
		SetData(data);
	}
}
