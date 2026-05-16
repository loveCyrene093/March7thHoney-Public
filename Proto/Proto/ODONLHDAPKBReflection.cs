using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ODONLHDAPKBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ODONLHDAPKBReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFPRE9OTEhEQVBLQi5wcm90byLKAQoLT0RPTkxIREFQS0ISEwoLSUJCTkxN";
		buffer[1] = "QkNMSEYYASABKA0SEwoLQ0NKRVBBQUpPSE8YAiABKA0SEwoLQUlKR0tJT01G";
		buffer[2] = "TFAYAyABKA0SEwoLRExER0hKRUpEUEYYBiABKA0SEwoLQ0dHTkxBQ0pHQ0wY";
		buffer[3] = "CCABKA0SEwoLRURCTk9ERU9IREEYCSABKAgSEwoLTk5BT0hNTUlCRUIYCiAB";
		buffer[4] = "KA0SEwoLQlBCS1BBS0VMR0gYCyABKA0SEwoLQUtES0xKTE9OQkEYDSABKA1C";
		buffer[5] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ODONLHDAPKB), ODONLHDAPKB.Parser, new string[9] { "IBBNLMBCLHF", "CCJEPAAJOHO", "AIJGKIOMFLP", "DLDGHJEJDPF", "CGGNLACJGCL", "EDBNODEOHDA", "NNAOHMMIBEB", "BPBKPAKELGH", "AKDKLJLONBA" }, null, null, null, null)
		}));
	}
}
