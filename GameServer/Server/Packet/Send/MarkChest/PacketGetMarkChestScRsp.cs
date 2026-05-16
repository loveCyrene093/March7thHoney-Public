using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Scene;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.MarkChest;

public class PacketGetMarkChestScRsp : BasePacket
{
	public PacketGetMarkChestScRsp(PlayerInstance player)
		: base(8200)
	{
		GetMarkChestScRsp data = new GetMarkChestScRsp
		{
			MarkChestFuncInfo = { player.SceneData.MarkedChestData.Select<KeyValuePair<int, List<SceneMarkedChestData>>, MarkChestFuncInfo>((KeyValuePair<int, List<SceneMarkedChestData>> x) => new MarkChestFuncInfo
			{
				FuncId = (uint)x.Key,
				MarkChestInfoList = { x.Value.Select((SceneMarkedChestData y) => y.ToProto()) }
			}) }
		};
		SetData(data);
	}
}
