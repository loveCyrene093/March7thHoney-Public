using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLMGOIBAKPHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLMGOIBAKPHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITE1HT0lCQUtQSC5wcm90bxoRREZMTUtGSUZIS0IucHJvdG8iVgoLSExN" + "R09JQkFLUEgSEwoLSUVQUEZLR0JGRVAYCiABKA0SIQoLR01GQ0lLQkdMSk0Y" + "DCADKAsyDC5ERkxNS0ZJRkhLQhIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DFLMKFIFHKBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLMGOIBAKPH), HLMGOIBAKPH.Parser, new string[3] { "IEPPFKGBFEP", "GMFCIKBGLJM", "Retcode" }, null, null, null, null)
		}));
	}
}
