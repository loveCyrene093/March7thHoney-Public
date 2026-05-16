using System;
using System.Collections.Generic;
using System.Reflection;

namespace March7thHoney.GameServer.Server.Packet;

public static class HandlerManager
{
	public static Dictionary<int, Handler> handlers = new Dictionary<int, Handler>();

	public static void Init()
	{
		Type[] types = Assembly.GetExecutingAssembly().GetTypes();
		foreach (Type type in types)
		{
			Opcode opcode = (Opcode)Attribute.GetCustomAttribute(type, typeof(Opcode));
			if (opcode != null)
			{
				handlers.Add(opcode.CmdId, (Handler)Activator.CreateInstance(type));
			}
		}
	}

	public static Handler? GetHandler(int cmdId)
	{
		try
		{
			return handlers[cmdId];
		}
		catch
		{
			return null;
		}
	}
}
