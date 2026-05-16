using System.Threading.Tasks;
using March7thHoney.Data.Config;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Mission;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mission;

[Opcode(1274)]
public class HandlerFinishCosumeItemMissionCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		FinishCosumeItemMissionCsReq req = FinishCosumeItemMissionCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		SubMissionInfo subMissionInfo = player.MissionManager?.GetSubMissionInfo((int)req.SubMissionId);
		if (subMissionInfo == null)
		{
			await connection.SendPacket(new PacketFinishCosumeItemMissionScRsp());
			return;
		}
		subMissionInfo.ParamItemList?.ForEach(async delegate(MaterialItem param)
		{
			await player.InventoryManager.RemoveItem(param.ItemID, param.ItemNum);
		});
		await player.MissionManager.FinishSubMission((int)req.SubMissionId);
		await connection.SendPacket(new PacketFinishCosumeItemMissionScRsp(req.SubMissionId));
	}
}
