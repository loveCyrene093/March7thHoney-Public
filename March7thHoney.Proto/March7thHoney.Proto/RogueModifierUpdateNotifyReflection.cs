using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueModifierUpdateNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueModifierUpdateNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Sb2d1ZU1vZGlmaWVyVXBkYXRlTm90aWZ5LnByb3RvGhFET0lKTkNMSkdL" + "Ty5wcm90byI+ChlSb2d1ZU1vZGlmaWVyVXBkYXRlTm90aWZ5EiEKC0lNSUJG" + "RUhQRERJGAQgASgLMgwuRE9JSk5DTEpHS09CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DOIJNCLJGKOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierUpdateNotify), RogueModifierUpdateNotify.Parser, new string[1] { "IMIBFEHPDDI" }, null, null, null, null)
		}));
	}
}
