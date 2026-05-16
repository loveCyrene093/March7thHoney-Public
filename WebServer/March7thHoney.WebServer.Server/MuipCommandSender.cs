using System;
using System.Threading.Tasks;
using March7thHoney.Command;

namespace March7thHoney.WebServer.Server;

public class MuipCommandSender : ICommandSender
{
	public MuipSession Session { get; }

	public Action<string> MsgAction { get; }

	public int SenderUid { get; set; }

	public MuipCommandSender(MuipSession session, Action<string> action)
	{
		Session = session;
		MsgAction = action;
		SenderUid = session.Account?.Uid ?? 0;
		base._002Ector();
	}

	public bool HasPermission(string permission)
	{
		if (Session.IsAdmin)
		{
			return true;
		}
		return Session.Account?.Permissions?.Contains(permission) == true;
	}

	public async ValueTask SendMsg(string msg)
	{
		MsgAction(msg);
		await Task.CompletedTask;
	}

	public int GetSender()
	{
		return SenderUid;
	}
}
