using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBLOMOFEPJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBLOMOFEPJDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQkxPTU9GRVBKRC5wcm90byItCgtCQkxPTU9GRVBKRBIPCgd2ZXJzaW9u" + "GAEgASgNEg0KBWNvdW50GAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBLOMOFEPJD), BBLOMOFEPJD.Parser, new string[2] { "Version", "Count" }, null, null, null, null)
		}));
	}
}
