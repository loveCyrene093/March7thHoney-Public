using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAssistListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAssistListCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHZXRBc3Npc3RMaXN0Q3NSZXEucHJvdG8iPgoSR2V0QXNzaXN0TGlzdENz" + "UmVxEhMKC0tKSk5PS0ZLTUNQGAogASgIEhMKC0lDSEVOT0pFQ0FQGAwgASgI" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAssistListCsReq), GetAssistListCsReq.Parser, new string[2] { "KJJNOKFKMCP", "ICHENOJECAP" }, null, null, null, null)
		}));
	}
}
