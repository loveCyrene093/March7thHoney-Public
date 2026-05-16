using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ILMJJCJMIPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ILMJJCJMIPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTE1KSkNKTUlQQi5wcm90byI1CgtJTE1KSkNKTUlQQhITCgtBTUZMTkxH" + "QkpHTBgJIAEoCBIRCglhdmF0YXJfaWQYDSABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ILMJJCJMIPB), ILMJJCJMIPB.Parser, new string[2] { "AMFLNLGBJGL", "AvatarId" }, null, null, null, null)
		}));
	}
}
