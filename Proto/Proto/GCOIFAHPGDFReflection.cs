using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCOIFAHPGDFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCOIFAHPGDFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFHQ09JRkFIUEdERi5wcm90bxoRRk9GTk9CSExLR08ucHJvdG8aEU5QTEVE";
		buffer[1] = "SEZNRkRNLnByb3RvIqcBCgtHQ09JRkFIUEdERhIhCgtBRkVKQUNNTE9MSBgB";
		buffer[2] = "IAMoCzIMLk5QTEVESEZNRkRNEiEKC1BFT0VDRERBTk5QGAIgASgLMgwuRk9G";
		buffer[3] = "Tk9CSExLR08SEwoLRklITUhKSEdIT0cYAyABKAMSEwoLREhMR0NFR09OSUIY";
		buffer[4] = "BCABKAMSEwoLR0pHQUdGRUpBQkMYBSABKA0SEwoLR0lJSUJDS0VPRFAYBiAB";
		buffer[5] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FOFNOBHLKGOReflection.Descriptor,
			NPLEDHFMFDMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GCOIFAHPGDF), GCOIFAHPGDF.Parser, new string[6] { "AFEJACMLOLH", "PEOECDDANNP", "FIHMHJHGHOG", "DHLGCEGONIB", "GJGAGFEJABC", "GIIIBCKEODP" }, null, null, null, null)
		}));
	}
}
