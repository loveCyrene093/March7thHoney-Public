using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GJBINEEABIPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GJBINEEABIPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSkJJTkVFQUJJUC5wcm90byIeCgtHSkJJTkVFQUJJUBIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GJBINEEABIP), GJBINEEABIP.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
