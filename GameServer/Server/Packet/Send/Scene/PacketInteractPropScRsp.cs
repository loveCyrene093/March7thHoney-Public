using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public class PacketInteractPropScRsp : BasePacket
{
	public PacketInteractPropScRsp(EntityProp? prop)
		: base(1495)
	{
		InteractPropScRsp interactPropScRsp = new InteractPropScRsp();
		if (prop != null)
		{
			interactPropScRsp.PropState = (uint)prop.State;
			interactPropScRsp.PropEntityId = (uint)prop.EntityId;
		}
		SetData(interactPropScRsp);
	}
}
