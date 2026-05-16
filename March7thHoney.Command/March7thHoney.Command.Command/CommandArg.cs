using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.GameServer.Server;
using March7thHoney.Kcp;
using March7thHoney.Util;

namespace March7thHoney.Command.Command;

public class CommandArg
{
	public string Raw { get; }

	public List<string> Args { get; } = new List<string>();

	public List<string> BasicArgs { get; } = new List<string>();

	public Dictionary<string, string> CharacterArgs { get; } = new Dictionary<string, string>();

	public Connection? Target { get; set; }

	public ICommandSender Sender { get; }

	public CommandArg(string raw, ICommandSender sender, Connection? con = null)
	{
		Raw = raw;
		Sender = sender;
		string[] array = raw.Split(' ');
		foreach (string text in array)
		{
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			char c = text[0];
			if (!int.TryParse(c.ToString(), out var _) && c != '-')
			{
				try
				{
					CharacterArgs.Add(text.Substring(0, 1), text.Substring(1));
					Args.Add(text);
				}
				catch
				{
					BasicArgs.Add(text);
					Args.Add(text);
				}
			}
			else
			{
				BasicArgs.Add(text);
				Args.Add(text);
			}
		}
		if (con != null)
		{
			Target = con;
		}
		CharacterArgs.TryGetValue("@", out string target);
		if (target != null && March7thHoneyListener.Connections.Values.ToList().Find((March7thHoneyConnection item) => (item as Connection)?.Player?.Uid.ToString() == target) is Connection target2)
		{
			Target = target2;
		}
	}

	public int GetInt(int index)
	{
		if (BasicArgs.Count <= index)
		{
			return 0;
		}
		int.TryParse(BasicArgs[index], out var result);
		return result;
	}

	public async ValueTask SendMsg(string msg)
	{
		await Sender.SendMsg(msg);
	}

	public override string ToString()
	{
		return $"BasicArg: {BasicArgs.ToArrayString()}. CharacterArg: {CharacterArgs.ToJsonString()}.";
	}
}
