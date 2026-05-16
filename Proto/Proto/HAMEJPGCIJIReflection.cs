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
		buffer[0] = "ChFIQU1FSlBHQ0lKSS5wcm90byKPAQoLSEFNRUpQR0NJSkkSEwoLSEZMSUFK";
		buffer[1] = "Q05KUEwYAiABKA0SEwoLR0hCTk9BTU9BTkQYAyABKA0SFAoMdG90YWxfZGFt";
		buffer[2] = "YWdlGAYgASgNEhgKEHRvdGFsX2F1dG9fdHVybnMYByABKA0SEQoJY29zdF90";
		buffer[3] = "aW1lGAogASgNEhMKC3RvdGFsX3R1cm5zGAwgASgNQhaqAhNNYXJjaDd0aEhv";
		buffer[4] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HAMEJPGCIJI), HAMEJPGCIJI.Parser, new string[6] { "HFLIAJCNJPL", "GHBNOAMOAND", "TotalDamage", "TotalAutoTurns", "CostTime", "TotalTurns" }, null, null, null, null)
		}));
	}
}
