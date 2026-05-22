using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HAMEJPGCIJIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HAMEJPGCIJIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFIQU1FSlBHQ0lKSS5wcm90byKPAQoLSEFNRUpQR0NJSkkSEwoLSEZMSUFK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Q05KUEwYAiABKA0SEwoLR0hCTk9BTU9BTkQYAyABKA0SFAoMdG90YWxfZGFt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YWdlGAYgASgNEhgKEHRvdGFsX2F1dG9fdHVybnMYByABKA0SEQoJY29zdF90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aW1lGAogASgNEhMKC3RvdGFsX3R1cm5zGAwgASgNQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HAMEJPGCIJI), HAMEJPGCIJI.Parser, new string[6] { "HFLIAJCNJPL", "GHBNOAMOAND", "TotalDamage", "TotalAutoTurns", "CostTime", "TotalTurns" }, null, null, null, null)
		}));
	}
}
