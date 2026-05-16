using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GFNMAKHPAOEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GFNMAKHPAOEReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFHRk5NQUtIUEFPRS5wcm90bxoRQkpPQkRMREhPQ0MucHJvdG8irgEKC0dG";
		buffer[1] = "Tk1BS0hQQU9FEhMKC1BKQ0dBSlBET0JOGAEgASgNEhMKC0dFTUhETkhEQUZC";
		buffer[2] = "GAIgASgNEhMKC0ZPT0xNSUFETU1IGAMgASgNEhMKC0lIUEdDQUFBR0JDGAQg";
		buffer[3] = "ASgNEiEKC0NKRUNJTkpQSUlKGAUgAygLMgwuQkpPQkRMREhPQ0MSEwoLTU5J";
		buffer[4] = "T0FOQU1GTUsYBiABKA0SEwoLR1BCRFBPT1BBQUQYByABKA1CFqoCE01hcmNo";
		buffer[5] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BJOBDLDHOCCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GFNMAKHPAOE), GFNMAKHPAOE.Parser, new string[7] { "PJCGAJPDOBN", "GEMHDNHDAFB", "FOOLMIADMMH", "IHPGCAAAGBC", "CJECINJPIIJ", "MNIOANAMFMK", "GPBDPOOPAAD" }, null, null, null, null)
		}));
	}
}
