using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SkillUsePropertyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SkillUsePropertyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChZTa2lsbFVzZVByb3BlcnR5LnByb3RvIs8BChBTa2lsbFVzZVByb3BlcnR5";
		buffer[1] = "EhAKCHNraWxsX2lkGAEgASgNEhIKCnNraWxsX3R5cGUYAiABKAkSEwoLc2tp";
		buffer[2] = "bGxfbGV2ZWwYAyABKA0SFwoPc2tpbGxfdXNlX2NvdW50GAQgASgNEhMKC0tF";
		buffer[3] = "QUZBTUlDQktEGAUgASgNEhMKC05DS0hGTUNNQkVDGAYgASgNEhMKC0RBTUxM";
		buffer[4] = "SEhPTUhIGAcgASgNEhMKC0VOSkVORk9PSE1EGAggASgNEhMKC0lMRkxLS0xN";
		buffer[5] = "Qk9JGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SkillUseProperty), SkillUseProperty.Parser, new string[9] { "SkillId", "SkillType", "SkillLevel", "SkillUseCount", "KEAFAMICBKD", "NCKHFMCMBEC", "DAMLLHHOMHH", "ENJENFOOHMD", "ILFLKKLMBOI" }, null, null, null, null)
		}));
	}
}
