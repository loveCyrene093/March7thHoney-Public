using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NLDDLGDEBMOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NLDDLGDEBMOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTERETEdERUJNTy5wcm90byIeCgtOTERETEdERUJNTxIPCgdyZXRjb2Rl" + "GAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NLDDLGDEBMO), NLDDLGDEBMO.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
