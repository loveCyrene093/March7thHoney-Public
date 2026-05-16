using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCLNBHMAIGCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCLNBHMAIGCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ0xOQkhNQUlHQy5wcm90byIgCgtGQ0xOQkhNQUlHQxIRCglhdmF0YXJf" + "aWQYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCLNBHMAIGC), FCLNBHMAIGC.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
