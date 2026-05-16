using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSectionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSectionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdFbnRlclNlY3Rpb25Dc1JlcS5wcm90byI8ChFFbnRlclNlY3Rpb25Dc1Jl" + "cRISCgpzZWN0aW9uX2lkGAEgASgNEhMKC2ludGVyYWN0X2lkGAsgASgEQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSectionCsReq), EnterSectionCsReq.Parser, new string[2] { "SectionId", "InteractId" }, null, null, null, null)
		}));
	}
}
