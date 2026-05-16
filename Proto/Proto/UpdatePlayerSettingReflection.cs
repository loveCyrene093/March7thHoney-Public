using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdatePlayerSettingReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdatePlayerSettingReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChlVcGRhdGVQbGF5ZXJTZXR0aW5nLnByb3RvGhFORUNHTUNHRkFOTi5wcm90";
		buffer[1] = "bxoRT0VFRUFFSkJFTkIucHJvdG8itgMKE1VwZGF0ZVBsYXllclNldHRpbmcS";
		buffer[2] = "FQoLQ0NOR0hCQURIQkwYAiABKAhIABIVCgtDSENORUROQ0lEShgEIAEoCEgA";
		buffer[3] = "EhUKC0NPSUdPQ0pIQk9QGAUgASgISAASFQoLUEZKTUVFQ0dKTU0YCCABKAhI";
		buffer[4] = "ABIVCgtOSExLRkJPQkRPTRgJIAEoCEgAEhUKC0ZJSk5BUE5JQ0pGGAogASgI";
		buffer[5] = "SAASIwoLRUhLTE5QQ01NSEUYCyABKAsyDC5PRUVFQUVKQkVOQkgAEhUKC0NQ";
		buffer[6] = "T0dES0FMR09NGA0gASgISAASFQoLTUZDUERKR0dDTU8YDiABKAhIABIVCgtM";
		buffer[7] = "UEVQSUROSkRFTRgPIAEoCEgAEhYKC0JNRUhGTUROS0xFGIwCIAEoCEgAEhYK";
		buffer[8] = "C0JLRENGQkRNTklKGMoDIAEoCEgAEhYKC0tGQkxIQ0NHRVBPGNoEIAEoCEgA";
		buffer[9] = "EhYKC0xFTktJRUJJSUhQGO4EIAEoCEgAEiQKC0hHSEZFQ09NSk5BGPkHIAEo";
		buffer[10] = "CzIMLk5FQ0dNQ0dGQU5OSAASFgoLRUpER05MRU9CQ04Y0AogASgISABCDQoL";
		buffer[11] = "TU9OUEdOQk9IRkNCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			NECGMCGFANNReflection.Descriptor,
			OEEEAEJBENBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdatePlayerSetting), UpdatePlayerSetting.Parser, new string[16]
			{
				"CCNGHBADHBL", "CHCNEDNCIDJ", "COIGOCJHBOP", "PFJMEECGJMM", "NHLKFBOBDOM", "FIJNAPNICJF", "EHKLNPCMMHE", "CPOGDKALGOM", "MFCPDJGGCMO", "LPEPIDNJDEM",
				"BMEHFMDNKLE", "BKDCFBDMNIJ", "KFBLHCCGEPO", "LENKIEBIIHP", "HGHFECOMJNA", "EJDGNLEOBCN"
			}, new string[1] { "MONPGNBOHFC" }, null, null, null)
		}));
	}
}
