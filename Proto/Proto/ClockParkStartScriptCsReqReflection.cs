using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkStartScriptCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkStartScriptCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DbG9ja1BhcmtTdGFydFNjcmlwdENzUmVxLnByb3RvIkMKGUNsb2NrUGFy" + "a1N0YXJ0U2NyaXB0Q3NSZXESEwoLREFOQUdEQVBLSkUYBiADKA0SEQoJc2Ny" + "aXB0X2lkGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkStartScriptCsReq), ClockParkStartScriptCsReq.Parser, new string[2] { "DANAGDAPKJE", "ScriptId" }, null, null, null, null)
		}));
	}
}
