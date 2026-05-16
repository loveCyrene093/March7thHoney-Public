using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketUpdateGroupPropertyScRsp : BasePacket
{
	public PacketUpdateGroupPropertyScRsp(Retcode code)
		: base(1464)
	{
		UpdateGroupPropertyScRsp data = new UpdateGroupPropertyScRsp
		{
			Retcode = (uint)code
		};
		SetData(data);
	}

	public PacketUpdateGroupPropertyScRsp(GroupPropertyRefreshData data, UpdateGroupPropertyCsReq req)
		: base(1464)
	{
		UpdateGroupPropertyScRsp data2 = new UpdateGroupPropertyScRsp
		{
			DimensionId = req.DimensionId,
			FloorId = req.FloorId,
			GroupId = (uint)data.GroupId,
			ELKOCIJNABK = data.NewValue,
			FNAODNGJAMM = data.OldValue,
			ELNCJFFJFIH = data.PropertyName
		};
		SetData(data2);
	}
}
