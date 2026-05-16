using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NLJLHPEOIOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NLJLHPEOIOCReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOTEpMSFBFT0lPQy5wcm90byKLAQoLTkxKTEhQRU9JT0MSEwoLRkNMQkdH";
		buffer[1] = "UEpHQ0UYAiABKA0SEwoLRERJREVFQUtDUFAYAyADKA0SEwoLSEFBQVBGTEdO";
		buffer[2] = "Qk0YBiABKA0SEwoLSE5PRkRMQkJISEYYCCABKAgSEwoLTEtDQ0tCS05LQlAY";
		buffer[3] = "DCABKA0SEwoLSEpLQVBCRU1FT08YDyABKARCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NLJLHPEOIOC), NLJLHPEOIOC.Parser, new string[6] { "FCLBGGPJGCE", "DDIDEEAKCPP", "HAAAPFLGNBM", "HNOFDLBBHHF", "LKCCKBKNKBP", "HJKAPBEMEOO" }, null, null, null, null)
		}));
	}
}
