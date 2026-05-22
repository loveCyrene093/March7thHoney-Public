using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ALGMCFBHJBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ALGMCFBHJBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTEdNQ0ZCSEpCSS5wcm90byIeCgtBTEdNQ0ZCSEpCSRIPCgdyZXRjb2Rl" + "GAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ALGMCFBHJBI), ALGMCFBHJBI.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
