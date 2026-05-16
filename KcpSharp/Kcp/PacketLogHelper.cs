using System;
using System.Collections.Concurrent;
using System.Reflection;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using March7thHoney.Proto;

namespace March7thHoney.Kcp;

public static class PacketLogHelper
{
	private delegate IMessage ParseIMessage(byte[] data);

	private static ConcurrentDictionary<ushort, ParseIMessage> CachedParsers { get; } = new ConcurrentDictionary<ushort, ParseIMessage>();

	public static string ConvertPacketToJson(ushort opcode, byte[] payload)
	{
		IMessage message = (GetParser(opcode) ?? throw new Exception())(payload);
		return JsonFormatter.Default.Format(message) ?? throw new Exception();
	}

	private static ParseIMessage? GetParser(ushort opcode)
	{
		if (CachedParsers.TryGetValue(opcode, out ParseIMessage value))
		{
			return value;
		}
		lock (CachedParsers)
		{
			Assembly assembly = Assembly.GetAssembly(typeof(PlayerGetTokenCsReq));
			if (assembly == null)
			{
				return null;
			}
			Type type = assembly.GetType("March7thHoney.Proto." + March7thHoneyConnection.LogMap[opcode]);
			if (type == null)
			{
				return null;
			}
			PropertyInfo property = type.GetProperty("Descriptor", BindingFlags.Static | BindingFlags.Public);
			if (property?.GetMethod == null)
			{
				return null;
			}
			if (!(property.GetValue(null) is MessageDescriptor messageDescriptor))
			{
				return null;
			}
			MethodInfo method = messageDescriptor.Parser.GetType().GetMethod("ParseFrom", new Type[1] { typeof(byte[]) });
			if (method == null)
			{
				return null;
			}
			value = (ParseIMessage)Delegate.CreateDelegate(typeof(ParseIMessage), messageDescriptor.Parser, method);
			CachedParsers[opcode] = value;
			return value;
		}
	}
}
