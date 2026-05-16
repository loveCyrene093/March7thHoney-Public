using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace March7thHoney.Configuration;

public class ServerProfile
{
	public string Name { get; set; } = "HyacineLover";

	public int Uid { get; set; } = 5201314;

	public string Signature { get; set; } = "Type /help for a list of commands";

	public int Level { get; set; } = 70;

	public int HeadIcon { get; set; } = 200139;

	public int ChatBubbleId { get; set; } = 220008;

	public int PersonalCardId { get; set; } = 253001;

	public List<ServerAssistInfo> AssistInfo { get; set; }

	public ServerProfile()
	{
		int num = 1;
		List<ServerAssistInfo> list = new List<ServerAssistInfo>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = new ServerAssistInfo
		{
			AvatarId = 1409,
			Level = 80
		};
		AssistInfo = list;
		base._002Ector();
	}
}
