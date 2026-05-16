using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerSettingInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerSettingInfoReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChdQbGF5ZXJTZXR0aW5nSW5mby5wcm90bxoRTkVDR01DR0ZBTk4ucHJvdG8a";
		buffer[1] = "EU9FRUVBRUpCRU5CLnByb3RvIoQDChFQbGF5ZXJTZXR0aW5nSW5mbxITCgtD";
		buffer[2] = "T0lHT0NKSEJPUBgCIAEoCBITCgtDSENORUROQ0lEShgEIAEoCBIhCgtFSEtM";
		buffer[3] = "TlBDTU1IRRgFIAEoCzIMLk9FRUVBRUpCRU5CEhMKC0xQRVBJRE5KREVNGAcg";
		buffer[4] = "ASgIEhMKC0JLRENGQkRNTklKGAggASgIEhMKC1BGSk1FRUNHSk1NGAkgASgI";
		buffer[5] = "EhMKC01GQ1BESkdHQ01PGAogASgIEhMKC0NDTkdIQkFESEJMGAsgASgIEhMK";
		buffer[6] = "C0ZJSk5BUE5JQ0pGGAwgASgIEhMKC05ITEtGQk9CRE9NGA0gASgIEhMKC0NQ";
		buffer[7] = "T0dES0FMR09NGA4gASgIEhQKC0xFTktJRUJJSUhQGJcBIAEoCBIUCgtFSkRH";
		buffer[8] = "TkxFT0JDThjFASABKAgSIgoLSEdIRkVDT01KTkEYjAQgASgLMgwuTkVDR01D";
		buffer[9] = "R0ZBTk4SFAoLS0ZCTEhDQ0dFUE8YwwkgASgIEhQKC0JNRUhGTUROS0xFGJUM";
		buffer[10] = "IAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			NECGMCGFANNReflection.Descriptor,
			OEEEAEJBENBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerSettingInfo), PlayerSettingInfo.Parser, new string[16]
			{
				"COIGOCJHBOP", "CHCNEDNCIDJ", "EHKLNPCMMHE", "LPEPIDNJDEM", "BKDCFBDMNIJ", "PFJMEECGJMM", "MFCPDJGGCMO", "CCNGHBADHBL", "FIJNAPNICJF", "NHLKFBOBDOM",
				"CPOGDKALGOM", "LENKIEBIIHP", "EJDGNLEOBCN", "HGHFECOMJNA", "KFBLHCCGEPO", "BMEHFMDNKLE"
			}, null, null, null, null)
		}));
	}
}
