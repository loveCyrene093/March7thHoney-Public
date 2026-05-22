using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FBDOEKFPDOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FBDOEKFPDOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQkRPRUtGUERPQi5wcm90byIeCgtGQkRPRUtGUERPQhIPCgdyZXRjb2Rl" + "GAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FBDOEKFPDOB), FBDOEKFPDOB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
