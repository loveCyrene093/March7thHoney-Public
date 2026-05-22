using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingDialogueSelectOptionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingDialogueSelectOptionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixTd29yZFRyYWluaW5nRGlhbG9ndWVTZWxlY3RPcHRpb25TY1JzcC5wcm90" + "byI5CiZTd29yZFRyYWluaW5nRGlhbG9ndWVTZWxlY3RPcHRpb25TY1JzcBIP" + "CgdyZXRjb2RlGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingDialogueSelectOptionScRsp), SwordTrainingDialogueSelectOptionScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
