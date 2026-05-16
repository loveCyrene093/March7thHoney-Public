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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChZTa2lsbFVzZVByb3BlcnR5LnByb3RvIs8BChBTa2lsbFVzZVByb3BlcnR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "EhAKCHNraWxsX2lkGAEgASgNEhIKCnNraWxsX3R5cGUYAiABKAkSEwoLc2tp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bGxfbGV2ZWwYAyABKA0SFwoPc2tpbGxfdXNlX2NvdW50GAQgASgNEhMKC0tF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QUZBTUlDQktEGAUgASgNEhMKC05DS0hGTUNNQkVDGAYgASgNEhMKC0RBTUxM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "SEhPTUhIGAcgASgNEhMKC0VOSkVORk9PSE1EGAggASgNEhMKC0lMRkxLS0xN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Qk9JGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SkillUseProperty), SkillUseProperty.Parser, new string[9] { "SkillId", "SkillType", "SkillLevel", "SkillUseCount", "KEAFAMICBKD", "NCKHFMCMBEC", "DAMLLHHOMHH", "ENJENFOOHMD", "ILFLKKLMBOI" }, null, null, null, null)
		}));
	}
}
