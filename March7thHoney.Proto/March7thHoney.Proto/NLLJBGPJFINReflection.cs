using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NLLJBGPJFINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NLLJBGPJFINReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTExKQkdQSkZJTi5wcm90byJiCgtOTExKQkdQSkZJThIPCgdyZXRjb2Rl" + "GAQgASgNEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QYCiADKA0SJQoddW5maW5p" + "c2hlZF9zdG9yeV9saW5lX2lkX2xpc3QYCyADKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NLLJBGPJFIN), NLLJBGPJFIN.Parser, new string[3] { "Retcode", "BaseAvatarIdList", "UnfinishedStoryLineIdList" }, null, null, null, null)
		}));
	}
}
