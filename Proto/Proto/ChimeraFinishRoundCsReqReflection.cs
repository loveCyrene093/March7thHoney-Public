using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraFinishRoundCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraFinishRoundCsReqReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		buffer[0] = "Ch1DaGltZXJhRmluaXNoUm91bmRDc1JlcS5wcm90bxoRQkNNTUxBREJFQU0u";
		buffer[1] = "cHJvdG8aH0NoaW1lcmFSb3VuZFdvcmtFbmRSZWFzb24ucHJvdG8aEUZIQ0ND";
		buffer[2] = "SEpISEtMLnByb3RvGhFIQU1FSlBHQ0lKSS5wcm90bxoRUENBT0xKTEZQQkEu";
		buffer[3] = "cHJvdG8i2gMKF0NoaW1lcmFGaW5pc2hSb3VuZENzUmVxEi4KCmVuZF9yZWFz";
		buffer[4] = "b24YASABKA4yGi5DaGltZXJhUm91bmRXb3JrRW5kUmVhc29uEhkKA3N0dBgC";
		buffer[5] = "IAEoCzIMLkhBTUVKUEdDSUpJEhMKC0xOQU9IREJHRU5PGAMgAygNEhMKC1BH";
		buffer[6] = "RUdNTUJJTklEGAYgASgIEhwKBmxpbmV1cBgKIAEoCzIMLkZIQ0NDSEpISEtM";
		buffer[7] = "EiEKC0tNQUZERkJKQ0pJGAsgAygLMgwuUENBT0xKTEZQQkESEwoLSkhES09C";
		buffer[8] = "S05QREUYDCABKA0SPgoLUEtJUE1OTkRJUEEYDSADKAsyKS5DaGltZXJhRmlu";
		buffer[9] = "aXNoUm91bmRDc1JlcS5QS0lQTU5ORElQQUVudHJ5Ej4KC0tNT0NIQ0ZMRENN";
		buffer[10] = "GA8gAygLMikuQ2hpbWVyYUZpbmlzaFJvdW5kQ3NSZXEuS01PQ0hDRkxEQ01F";
		buffer[11] = "bnRyeRoyChBQS0lQTU5ORElQQUVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1";
		buffer[12] = "ZRgCIAEoDToCOAEaQAoQS01PQ0hDRkxEQ01FbnRyeRILCgNrZXkYASABKA0S";
		buffer[13] = "GwoFdmFsdWUYAiABKAsyDC5CQ01NTEFEQkVBTToCOAFCFqoCE01hcmNoN3Ro";
		buffer[14] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			BCMMLADBEAMReflection.Descriptor,
			ChimeraRoundWorkEndReasonReflection.Descriptor,
			FHCCCHJHHKLReflection.Descriptor,
			HAMEJPGCIJIReflection.Descriptor,
			PCAOLJLFPBAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraFinishRoundCsReq), ChimeraFinishRoundCsReq.Parser, new string[9] { "EndReason", "Stt", "LNAOHDBGENO", "PGEGMMBINID", "Lineup", "KMAFDFBJCJI", "JHDKOBKNPDE", "PKIPMNNDIPA", "KMOCHCFLDCM" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
