using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Message;

public class PacketGetNpcStatusScRsp : BasePacket
{
	public PacketGetNpcStatusScRsp(PlayerInstance player)
		: base(2795)
	{
		GetNpcStatusScRsp getNpcStatusScRsp = new GetNpcStatusScRsp();
		foreach (MessageContactsConfigExcel value in GameData.MessageContactsConfigData.Values)
		{
			getNpcStatusScRsp.NpcStatusList.Add(new NpcStatus
			{
				NpcId = (uint)value.ID,
				IsFinish = (player.MessageManager.GetMessageGroup(value.ID).Count > 0)
			});
		}
		SetData(getNpcStatusScRsp);
	}
}
