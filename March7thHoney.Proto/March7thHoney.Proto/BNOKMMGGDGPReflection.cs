using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNOKMMGGDGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNOKMMGGDGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTk9LTU1HR0RHUC5wcm90byIeCgtCTk9LTU1HR0RHUBIPCgdyZXRjb2Rl" + "GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNOKMMGGDGP), BNOKMMGGDGP.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
