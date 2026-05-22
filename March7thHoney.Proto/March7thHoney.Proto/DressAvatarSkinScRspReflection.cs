using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DressAvatarSkinScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DressAvatarSkinScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEcmVzc0F2YXRhclNraW5TY1JzcC5wcm90byInChREcmVzc0F2YXRhclNr" + "aW5TY1JzcBIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DressAvatarSkinScRsp), DressAvatarSkinScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
