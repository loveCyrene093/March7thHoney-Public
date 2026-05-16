using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.TrainParty;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.TrainParty;

public class PacketTrainPartyBuildDiyScRsp : BasePacket
{
	public PacketTrainPartyBuildDiyScRsp(TrainAreaInfo? area)
		: base(8038)
	{
		SetData((area == null) ? new TrainPartyBuildDiyScRsp
		{
			Retcode = 6502u
		} : new TrainPartyBuildDiyScRsp
		{
			AreaId = (uint)area.AreaId,
			DynamicInfo = { area.DynamicInfo.Select((KeyValuePair<int, int> x) => new AreaDynamicInfo
			{
				DiceSlotId = (uint)x.Key,
				DiyDynamicId = (uint)x.Value
			}) }
		});
	}
}
