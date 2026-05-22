using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FLOEMBHNEPPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FLOEMBHNEPPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTE9FTUJITkVQUC5wcm90byJyCgtGTE9FTUJITkVQUBIPCgdyb29tX2lk" + "GAEgASgEEhMKC01NTEtGSklBS0tIGAIgASgNEhMKC05ES0FJQUZQTkJKGAMg" + "ASgNEhMKC0xES0dKQkFMR0tDGAQgASgNEhMKC0hISExDQU5HQUJMGAUgASgJ" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FLOEMBHNEPP), FLOEMBHNEPP.Parser, new string[5] { "RoomId", "MMLKFJIAKKH", "NDKAIAFPNBJ", "LDKGJBALGKC", "HHHLCANGABL" }, null, null, null, null)
		}));
	}
}
