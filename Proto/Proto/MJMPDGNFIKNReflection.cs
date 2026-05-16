using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJMPDGNFIKNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJMPDGNFIKNReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFNSk1QREdORklLTi5wcm90bxoRRk9DSEdQR0dOQ0wucHJvdG8aEUhBR0tC";
		buffer[1] = "RlBOUFBILnByb3RvIqMCCgtNSk1QREdORklLThIhCgtCTEZQUEZDQURCQhgC";
		buffer[2] = "IAMoCzIMLkZPQ0hHUEdHTkNMEiEKC0xDRUhER0JCREpMGAMgAygLMgwuSEFH";
		buffer[3] = "S0JGUE5QUEgSMgoLS1BJREpNQk5DTkgYBiADKAsyHS5NSk1QREdORklLTi5L";
		buffer[4] = "UElESk1CTkNOSEVudHJ5EjIKC0tJQkdOSk5BRERIGA8gAygLMh0uTUpNUERH";
		buffer[5] = "TkZJS04uS0lCR05KTkFEREhFbnRyeRoyChBLUElESk1CTkNOSEVudHJ5EgsK";
		buffer[6] = "A2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAEaMgoQS0lCR05KTkFEREhF";
		buffer[7] = "bnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJj";
		buffer[8] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FOCHGPGGNCLReflection.Descriptor,
			HAGKBFPNPPHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJMPDGNFIKN), MJMPDGNFIKN.Parser, new string[4] { "BLFPPFCADBB", "LCEHDGBBDJL", "KPIDJMBNCNH", "KIBGNJNADDH" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
