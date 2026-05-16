using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueGetGambleInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueGetGambleInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb2d1ZUdldEdhbWJsZUluZm9TY1JzcC5wcm90bxoRREtGQUVLUEtBREgu" + "cHJvdG8iTQoXUm9ndWVHZXRHYW1ibGVJbmZvU2NSc3ASIQoLQ0ZBREZMTExP" + "UEMYAyABKAsyDC5ES0ZBRUtQS0FESBIPCgdyZXRjb2RlGAUgASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DKFAEKPKADHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueGetGambleInfoScRsp), RogueGetGambleInfoScRsp.Parser, new string[2] { "CFADFLLLOPC", "Retcode" }, null, null, null, null)
		}));
	}
}
