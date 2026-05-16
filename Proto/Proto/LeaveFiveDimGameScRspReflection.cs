using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveFiveDimGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveFiveDimGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtMZWF2ZUZpdmVEaW1HYW1lU2NSc3AucHJvdG8iRAoVTGVhdmVGaXZlRGlt" + "R2FtZVNjUnNwEhoKEmNsaWVudF9wb3NfdmVyc2lvbhgCIAEoDRIPCgdyZXRj" + "b2RlGAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveFiveDimGameScRsp), LeaveFiveDimGameScRsp.Parser, new string[2] { "ClientPosVersion", "Retcode" }, null, null, null, null)
		}));
	}
}
