using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.PamSkin;

public class PacketGetPamSkinDataScRsp : BasePacket
{
	public PacketGetPamSkinDataScRsp(PlayerInstance player)
		: base(8140)
	{
		GetPamSkinDataScRsp data = new GetPamSkinDataScRsp
		{
			CurSkin = (uint)player.Data.CurrentPamSkin,
			UnlockSkinList = { GameData.PamSkinConfigData.Select<KeyValuePair<int, PamSkinConfigExcel>, uint>((KeyValuePair<int, PamSkinConfigExcel> x) => (uint)x.Key) }
		};
		SetData(data);
	}
}
