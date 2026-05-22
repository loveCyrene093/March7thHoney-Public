using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGenderScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGenderScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTZXRHZW5kZXJTY1JzcC5wcm90bxoZTXVsdGlQYXRoQXZhdGFyVHlwZS5w" + "cm90byJQCg5TZXRHZW5kZXJTY1JzcBIPCgdyZXRjb2RlGAMgASgNEi0KD2N1" + "cl9hdmF0YXJfcGF0aBgEIAEoDjIULk11bHRpUGF0aEF2YXRhclR5cGVCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MultiPathAvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGenderScRsp), SetGenderScRsp.Parser, new string[2] { "Retcode", "CurAvatarPath" }, null, null, null, null)
		}));
	}
}
