using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Database.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.MarkChest;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.MarkChest;

[Opcode(8182)]
public class HandlerUpdateMarkChestCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		UpdateMarkChestCsReq updateMarkChestCsReq = UpdateMarkChestCsReq.Parser.ParseFrom(data);
		PlayerInstance player = connection.Player;
		List<SceneMarkedChestData> markedChestData = new List<SceneMarkedChestData>();
		foreach (MarkChestInfo markChestInfo in updateMarkChestCsReq.MarkChestInfoList)
		{
			markedChestData.Add(new SceneMarkedChestData
			{
				ConfigId = (int)markChestInfo.ConfigId,
				FloorId = (int)markChestInfo.FloorId,
				GroupId = (int)markChestInfo.GroupId,
				PlaneId = (int)markChestInfo.PlaneId
			});
		}
		foreach (SceneMarkedChestData item in (player.SceneData.MarkedChestData.GetValueOrDefault((int)updateMarkChestCsReq.FuncId) ?? new List<SceneMarkedChestData>()).Where((SceneMarkedChestData chestData) => markedChestData.All((SceneMarkedChestData x) => x.ConfigId != chestData.ConfigId || x.FloorId != chestData.FloorId || x.GroupId != chestData.GroupId)))
		{
			markedChestData.Add(item);
		}
		player.SceneData.MarkedChestData[(int)updateMarkChestCsReq.FuncId] = markedChestData;
		await connection.SendPacket(new PacketUpdateMarkChestScRsp(updateMarkChestCsReq.FuncId, player));
	}
}
