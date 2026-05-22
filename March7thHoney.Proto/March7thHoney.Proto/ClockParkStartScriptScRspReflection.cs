using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkStartScriptScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkStartScriptScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DbG9ja1BhcmtTdGFydFNjcmlwdFNjUnNwLnByb3RvIj8KGUNsb2NrUGFy" + "a1N0YXJ0U2NyaXB0U2NSc3ASDwoHcmV0Y29kZRgEIAEoDRIRCglzY3JpcHRf" + "aWQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkStartScriptScRsp), ClockParkStartScriptScRsp.Parser, new string[2] { "Retcode", "ScriptId" }, null, null, null, null)
		}));
	}
}
