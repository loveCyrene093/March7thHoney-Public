using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueModifierDelNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueModifierDelNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZU1vZGlmaWVyRGVsTm90aWZ5LnByb3RvIi0KFlJvZ3VlTW9kaWZp" + "ZXJEZWxOb3RpZnkSEwoLUElNTkVFRkRBR0UYAiABKARCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierDelNotify), RogueModifierDelNotify.Parser, new string[1] { "PIMNEEFDAGE" }, null, null, null, null)
		}));
	}
}
