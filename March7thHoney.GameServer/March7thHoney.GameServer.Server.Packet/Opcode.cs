using System;

namespace March7thHoney.GameServer.Server.Packet;

[AttributeUsage(AttributeTargets.Class)]
public class Opcode : Attribute
{
	public int CmdId;

	public Opcode(int cmdId)
	{
		CmdId = cmdId;
		base._002Ector();
	}
}
