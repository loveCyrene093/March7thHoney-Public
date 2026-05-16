using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BGKINCFGKGIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BGKINCFGKGIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCR0tJTkNGR0tHSS5wcm90byKgAQoLQkdLSU5DRkdLR0kSEwoLT0VCSENE";
		buffer[1] = "UEROSEYYASABKAMSEwoLTUJNSUNDSkVCSkIYAyABKA0SEwoLTk1DS0pMSEZQ";
		buffer[2] = "QkoYBSABKAMSEwoLSEFPQkpBQkNCTVAYByABKA0SEwoLR0FNQ1BMSk9FREsY";
		buffer[3] = "CSABKAgSEwoLREZMS05MTUpPRkIYDCADKA0SEwoLQURHQktLSU1KT0EYDSAB";
		buffer[4] = "KAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BGKINCFGKGI), BGKINCFGKGI.Parser, new string[7] { "OEBHCDPDNHF", "MBMICCJEBJB", "NMCKJLHFPBJ", "HAOBJABCBMP", "GAMCPLJOEDK", "DFLKNLMJOFB", "ADGBKKIMJOA" }, null, null, null, null)
		}));
	}
}
