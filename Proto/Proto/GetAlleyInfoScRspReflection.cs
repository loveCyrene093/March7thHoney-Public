using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAlleyInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAlleyInfoScRspReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChdHZXRBbGxleUluZm9TY1JzcC5wcm90bxoRRENNSkNOT0tLTk4ucHJvdG8a";
		buffer[1] = "EUdFT0FBQU9BUEdLLnByb3RvGhFNS1BEQ0lMRUxBQS5wcm90bxoRUExJRUVE";
		buffer[2] = "S0hHTk4ucHJvdG8ikwMKEUdldEFsbGV5SW5mb1NjUnNwEiEKC0hCTUpJR0dC";
		buffer[3] = "RktQGAEgASgLMgwuR0VPQUFBT0FQR0sSDQoFbGV2ZWwYBCABKA0SEwoLSk9O";
		buffer[4] = "S0hQS05OTEQYBSABKA0SIQoLUEFEREVKRExGTEEYBiADKAsyDC5EQ01KQ05P";
		buffer[5] = "S0tOThIQCghjdXJfZnVuZBgHIAEoDRIhCgtKS0NESklQTkxQSRgIIAEoCzIM";
		buffer[6] = "Lk1LUERDSUxFTEFBEhMKC0lCTlBBTkpHS09JGAogAygNEiEKC05MRUpQTUVE";
		buffer[7] = "Qk5IGAsgASgLMgwuUExJRUVES0hHTk4SOAoLQkVORUlGQUhJR0oYDCADKAsy";
		buffer[8] = "Iy5HZXRBbGxleUluZm9TY1JzcC5CRU5FSUZBSElHSkVudHJ5EhMKC0xBRklC";
		buffer[9] = "R0JJSUlFGA0gAygNEhMKC0dDRkVDUEpLRE1LGA4gAygNEg8KB3JldGNvZGUY";
		buffer[10] = "DyABKA0aMgoQQkVORUlGQUhJR0pFbnRyeRILCgNrZXkYASABKA0SDQoFdmFs";
		buffer[11] = "dWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			DCMJCNOKKNNReflection.Descriptor,
			GEOAAAOAPGKReflection.Descriptor,
			MKPDCILELAAReflection.Descriptor,
			PLIEEDKHGNNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAlleyInfoScRsp), GetAlleyInfoScRsp.Parser, new string[12]
			{
				"HBMJIGGBFKP", "Level", "JONKHPKNNLD", "PADDEJDLFLA", "CurFund", "JKCDJIPNLPI", "IBNPANJGKOI", "NLEJPMEDBNH", "BENEIFAHIGJ", "LAFIBGBIIIE",
				"GCFECPJKDMK", "Retcode"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
