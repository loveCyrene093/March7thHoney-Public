using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateStartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateStartScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRGYXRlU3RhcnRTY1JzcC5wcm90bxoRS0RKSURKQkJISEUucHJvdG8iRAoO" + "RmF0ZVN0YXJ0U2NSc3ASDwoHcmV0Y29kZRgFIAEoDRIhCgtNT0RESUJIQ1BQ" + "RBgOIAEoCzIMLktESklESkJCSEhFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[1] { KDJIDJBBHHEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateStartScRsp), FateStartScRsp.Parser, new string[2] { "Retcode", "MODDIBHCPPD" }, null, null, null, null)
		}));
	}
}
