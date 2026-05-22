using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCMKANNIKDPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCMKANNIKDPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ01LQU5OSUtEUC5wcm90byJ7CgtCQ01LQU5OSUtEUBIPCgdyb29tX2lk" + "GAEgASgEEhMKC01NTEtGSklBS0tIGAIgASgNEhMKC0xES0dKQkFMR0tDGAMg" + "ASgNEhMKC01GTERNS0pIUE9LGAQgASgNEgwKBHR5cGUYBSABKA0SDgoGcmVh" + "c29uGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCMKANNIKDP), BCMKANNIKDP.Parser, new string[6] { "RoomId", "MMLKFJIAKKH", "LDKGJBALGKC", "MFLDMKJHPOK", "Type", "Reason" }, null, null, null, null)
		}));
	}
}
