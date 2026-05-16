using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookUnlockStoryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookUnlockStoryScRspReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "Ch9UYXJvdEJvb2tVbmxvY2tTdG9yeVNjUnNwLnByb3RvGhFJUEpPSktQQkZH";
		buffer[1] = "Sy5wcm90byLQAgoZVGFyb3RCb29rVW5sb2NrU3RvcnlTY1JzcBJACgtDSkxH";
		buffer[2] = "UENBT1BGQxgCIAMoCzIrLlRhcm90Qm9va1VubG9ja1N0b3J5U2NSc3AuQ0pM";
		buffer[3] = "R1BDQU9QRkNFbnRyeRIPCgdyZXRjb2RlGAQgASgNEkAKC0NDQ0tNQUNLTEtH";
		buffer[4] = "GAggAygLMisuVGFyb3RCb29rVW5sb2NrU3RvcnlTY1JzcC5DQ0NLTUFDS0xL";
		buffer[5] = "R0VudHJ5EiEKC1BGS0hJSUZCTkREGAkgASgLMgwuSVBKT0pLUEJGR0sSEwoL";
		buffer[6] = "TEVHTE9JTU5QRUMYCiADKA0aMgoQQ0pMR1BDQU9QRkNFbnRyeRILCgNrZXkY";
		buffer[7] = "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBGjIKEENDQ0tNQUNLTEtHRW50cnkS";
		buffer[8] = "CwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhI";
		buffer[9] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { IPJOJKPBFGKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookUnlockStoryScRsp), TarotBookUnlockStoryScRsp.Parser, new string[5] { "CJLGPCAOPFC", "Retcode", "CCCKMACKLKG", "PFKHIIFBNDD", "LEGLOIMNPEC" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
