using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IBFOFJCOAFFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IBFOFJCOAFFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFJQkZPRkpDT0FGRi5wcm90byKgAQoLSUJGT0ZKQ09BRkYSEwoLUEVGTEhL";
		buffer[1] = "TUJPQ00YAiABKA0SEwoLQUFPR0tLS0VJSUwYAyADKA0SEwoLSEFISFBGT0xB";
		buffer[2] = "SUcYBCADKA0SEwoLTUVIQkZLREZHTkYYBSADKA0SEwoLQ0dJUERKQ05GTEoY";
		buffer[3] = "ByADKA0SEwoLRkpOUExQTklGQkEYCyADKA0SEwoLTEFEQ0VFSEFKREcYDSAD";
		buffer[4] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IBFOFJCOAFF), IBFOFJCOAFF.Parser, new string[7] { "PEFLHKMBOCM", "AAOGKKKEIIL", "HAHHPFOLAIG", "MEHBFKDFGNF", "CGIPDJCNFLJ", "FJNPLPNIFBA", "LADCEEHAJDG" }, null, null, null, null)
		}));
	}
}
