using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KGLOGMHODNBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KGLOGMHODNBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLR0xPR01IT0ROQi5wcm90byJICgtLR0xPR01IT0ROQhIPCgdjYXJkX2lk" + "GAIgASgNEhMKC0hMQURKUE1ET0FCGAYgASgNEhMKC0ZBTUZDSVBMR09OGAcg" + "AygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KGLOGMHODNB), KGLOGMHODNB.Parser, new string[3] { "CardId", "HLADJPMDOAB", "FAMFCIPLGON" }, null, null, null, null)
		}));
	}
}
