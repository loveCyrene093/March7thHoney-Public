using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAetherDivideInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAetherDivideInfoScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "Ch5HZXRBZXRoZXJEaXZpZGVJbmZvU2NSc3AucHJvdG8aEURMR0ZQTUtQTEVP";
		buffer[1] = "LnByb3RvGhFKQkpJS0pHRUJBSC5wcm90bxoRS05IS0JIQURKR0UucHJvdG8i";
		buffer[2] = "/QEKGEdldEFldGhlckRpdmlkZUluZm9TY1JzcBITCgtLQkZGQlBERENGRhgB";
		buffer[3] = "IAEoDRIPCgdyZXRjb2RlGAIgASgNEhMKC09KUEpQT0dETE5PGAQgASgNEiEK";
		buffer[4] = "C0dPTk9PT0VISExPGAUgAygLMgwuS05IS0JIQURKR0USIQoLbGluZXVwX2xp";
		buffer[5] = "c3QYBiADKAsyDC5ETEdGUE1LUExFTxITCgtGSUtMTE9DSkJHThgIIAEoDRIT";
		buffer[6] = "CgtDRkNGQ0VCTkFFRhgLIAEoDRITCgtPQU1QR05ISklHRBgMIAEoDRIhCgtQ";
		buffer[7] = "SEdMRkhEREFDTRgNIAMoCzIMLkpCSklLSkdFQkFIQhaqAhNNYXJjaDd0aEhv";
		buffer[8] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			DLGFPMKPLEOReflection.Descriptor,
			JBJIKJGEBAHReflection.Descriptor,
			KNHKBHADJGEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAetherDivideInfoScRsp), GetAetherDivideInfoScRsp.Parser, new string[9] { "KBFFBPDDCFF", "Retcode", "OJPJPOGDLNO", "GONOOOEHHLO", "LineupList", "FIKLLOCJBGN", "CFCFCEBNAEF", "OAMPGNHJIGD", "PHGLFHDDACM" }, null, null, null, null)
		}));
	}
}
