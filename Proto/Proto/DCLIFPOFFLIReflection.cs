using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCLIFPOFFLIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCLIFPOFFLIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFEQ0xJRlBPRkZMSS5wcm90bxoRUEhIS05BQURCSEEucHJvdG8ibwoLRENM";
		buffer[1] = "SUZQT0ZGTEkSEwoLSE1JQkpIRE1MTkIYAiABKA0SEwoLUFBOSE5ERU9PTEoY";
		buffer[2] = "AyABKAQSEwoLTkZQQkFLQkNDSEcYBCABKA0SIQoLTkVCR05PRlBBR0UYDiAD";
		buffer[3] = "KAsyDC5QSEhLTkFBREJIQUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PHHKNAADBHAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DCLIFPOFFLI), DCLIFPOFFLI.Parser, new string[4] { "HMIBJHDMLNB", "PPNHNDEOOLJ", "NFPBAKBCCHG", "NEBGNOFPAGE" }, null, null, null, null)
		}));
	}
}
