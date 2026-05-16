using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueModifierAddNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueModifierAddNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZU1vZGlmaWVyQWRkTm90aWZ5LnByb3RvGhFET0lKTkNMSkdLTy5w" + "cm90byI7ChZSb2d1ZU1vZGlmaWVyQWRkTm90aWZ5EiEKC0lNSUJGRUhQRERJ" + "GAcgASgLMgwuRE9JSk5DTEpHS09CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[1] { DOIJNCLJGKOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierAddNotify), RogueModifierAddNotify.Parser, new string[1] { "IMIBFEHPDDI" }, null, null, null, null)
		}));
	}
}
