using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CommonRogueQueryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CommonRogueQueryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDb21tb25Sb2d1ZVF1ZXJ5Q3NSZXEucHJvdG8iLAoVQ29tbW9uUm9ndWVR" + "dWVyeUNzUmVxEhMKC0lCSEFKREJNUEVEGAYgAygNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CommonRogueQueryCsReq), CommonRogueQueryCsReq.Parser, new string[1] { "IBHAJDBMPED" }, null, null, null, null)
		}));
	}
}
