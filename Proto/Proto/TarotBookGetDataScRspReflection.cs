using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookGetDataScRspReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChtUYXJvdEJvb2tHZXREYXRhU2NSc3AucHJvdG8aEUNESE9LTUFBTUZELnBy";
		buffer[1] = "b3RvGhFHQlBCTUZDT0RQRi5wcm90byKRAwoVVGFyb3RCb29rR2V0RGF0YVNj";
		buffer[2] = "UnNwEhMKC0ZCT0ZNT1BDTUNEGAIgASgNEiEKC0NQRU1MSUFHQktCGAMgASgL";
		buffer[3] = "MgwuQ0RIT0tNQUFNRkQSEwoLSkdLQ0JHQkdNT0QYByABKA0SIQoLSk5LSE9L";
		buffer[4] = "SkhCQk8YCCABKAsyDC5HQlBCTUZDT0RQRhIPCgdyZXRjb2RlGAkgASgNEhMK";
		buffer[5] = "C2VuZXJneV9pbmZvGA0gASgNEjwKC0NKTEdQQ0FPUEZDGA4gAygLMicuVGFy";
		buffer[6] = "b3RCb29rR2V0RGF0YVNjUnNwLkNKTEdQQ0FPUEZDRW50cnkSPAoLQ0NDS01B";
		buffer[7] = "Q0tMS0cYDyADKAsyJy5UYXJvdEJvb2tHZXREYXRhU2NSc3AuQ0NDS01BQ0tM";
		buffer[8] = "S0dFbnRyeRoyChBDSkxHUENBT1BGQ0VudHJ5EgsKA2tleRgBIAEoDRINCgV2";
		buffer[9] = "YWx1ZRgCIAEoDToCOAEaMgoQQ0NDS01BQ0tMS0dFbnRyeRILCgNrZXkYASAB";
		buffer[10] = "KA0SDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[11] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CDHOKMAAMFDReflection.Descriptor,
			GBPBMFCODPFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookGetDataScRsp), TarotBookGetDataScRsp.Parser, new string[8] { "FBOFMOPCMCD", "CPEMLIAGBKB", "JGKCBGBGMOD", "JNKHOKJHBBO", "Retcode", "EnergyInfo", "CJLGPCAOPFC", "CCCKMACKLKG" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
