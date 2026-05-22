using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraQuitEndlessScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraQuitEndlessScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGltZXJhUXVpdEVuZGxlc3NTY1JzcC5wcm90byIqChdDaGltZXJhUXVp" + "dEVuZGxlc3NTY1JzcBIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraQuitEndlessScRsp), ChimeraQuitEndlessScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
