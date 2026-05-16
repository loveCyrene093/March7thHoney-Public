using System.Linq;
using March7thHoney.Data;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;

public class PacketGetChallengePeakDataScRsp : BasePacket
{
	public PacketGetChallengePeakDataScRsp(PlayerInstance player)
		: base(8907)
	{
		int num = GameData.GetCurrentChallengePeakGroupId();
		if (!GameData.ChallengePeakGroupConfigData.ContainsKey(num) && GameData.ChallengePeakGroupConfigData.Count > 0)
		{
			num = GameData.ChallengePeakGroupConfigData.Keys.Max();
		}
		GetChallengePeakDataScRsp getChallengePeakDataScRsp = new GetChallengePeakDataScRsp
		{
			CurrentPeakGroupId = (uint)num
		};
		foreach (int item in GameData.ChallengePeakGroupConfigData.Keys.OrderBy((int x) => x))
		{
			getChallengePeakDataScRsp.ChallengePeakGroups.Add(player.ChallengePeakManager.GetChallengePeakInfo(item));
		}
		SetData(getChallengePeakDataScRsp);
	}
}
