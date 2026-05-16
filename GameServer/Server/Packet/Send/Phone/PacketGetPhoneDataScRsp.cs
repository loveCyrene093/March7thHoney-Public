using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Phone;

public class PacketGetPhoneDataScRsp : BasePacket
{
	public PacketGetPhoneDataScRsp(PlayerInstance player)
		: base(5110)
	{
		GetPhoneDataScRsp getPhoneDataScRsp = new GetPhoneDataScRsp
		{
			CurChatBubble = (uint)player.Data.ChatBubble,
			CurPhoneTheme = (uint)player.Data.PhoneTheme,
			CurPhoneCase = (uint)player.Data.PhoneCase
		};
		foreach (int phoneTheme in player.PlayerUnlockData.PhoneThemes)
		{
			getPhoneDataScRsp.OwnedPhoneThemes.Add((uint)phoneTheme);
		}
		foreach (int chatBubble in player.PlayerUnlockData.ChatBubbles)
		{
			getPhoneDataScRsp.OwnedChatBubbles.Add((uint)chatBubble);
		}
		foreach (int phoneCase in player.PlayerUnlockData.PhoneCases)
		{
			getPhoneDataScRsp.OwnedPhoneCases.Add((uint)phoneCase);
		}
		SetData(getPhoneDataScRsp);
	}
}
