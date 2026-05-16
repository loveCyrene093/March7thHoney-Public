using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Avatar;

public class PacketAvatarExpUpScRsp : BasePacket
{
	public PacketAvatarExpUpScRsp(List<ItemData> returnItem)
		: base(395)
	{
		AvatarExpUpScRsp avatarExpUpScRsp = new AvatarExpUpScRsp();
		avatarExpUpScRsp.ReturnItemList.AddRange(returnItem.Select((ItemData item) => item.ToPileProto()));
		SetData(avatarExpUpScRsp);
	}
}
