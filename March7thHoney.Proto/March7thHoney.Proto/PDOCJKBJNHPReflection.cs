using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PDOCJKBJNHPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PDOCJKBJNHPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRE9DSktCSk5IUC5wcm90byIeCgtQRE9DSktCSk5IUBIPCgdyZXRjb2Rl" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PDOCJKBJNHP), PDOCJKBJNHP.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
