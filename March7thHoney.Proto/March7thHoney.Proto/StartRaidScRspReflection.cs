using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartRaidScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartRaidScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTdGFydFJhaWRTY1JzcC5wcm90bxoRRk5KSkNJR0pJS0MucHJvdG8iPgoO" + "U3RhcnRSYWlkU2NSc3ASDwoHcmV0Y29kZRgKIAEoDRIbCgVzY2VuZRgOIAEo" + "CzIMLkZOSkpDSUdKSUtDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { FNJJCIGJIKCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartRaidScRsp), StartRaidScRsp.Parser, new string[2] { "Retcode", "Scene" }, null, null, null, null)
		}));
	}
}
