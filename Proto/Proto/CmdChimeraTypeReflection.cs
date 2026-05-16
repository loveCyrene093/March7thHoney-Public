using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdChimeraTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdChimeraTypeReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		buffer[0] = "ChRDbWRDaGltZXJhVHlwZS5wcm90byqjBAoOQ21kQ2hpbWVyYVR5cGUSGwoX";
		buffer[1] = "RUNHQ1BLTEhERUNfUENQREhFTFBLRU0QABIgChtDbWRDaGltZXJhU3RhcnRF";
		buffer[2] = "bmRsZXNzQ3NSZXEQ7j8SFAoPQ21kR2V0RGF0YVNjUnNwEPQ/EiYKIUNtZENo";
		buffer[3] = "aW1lcmFGaW5pc2hFbmRsZXNzUm91bmRTY1JzcBDzPxIfChpDbWRDaGltZXJh";
		buffer[4] = "UXVpdEVuZGxlc3NTY1JzcBDyPxIfChpDbWRDaGltZXJhRmluaXNoUm91bmRD";
		buffer[5] = "c1JlcRDvPxIaChVDbWRDaGltZXJhRmluaXNoUm91bmQQ6D8SEwoOQ21kSU5J";
		buffer[6] = "RUxEQ0FHREcQ7T8SIAobQ21kQ2hpbWVyYURvRmluYWxSb3VuZFNjUnNwEOM/";
		buffer[7] = "EiAKG0NtZENoaW1lcmFTdGFydEVuZGxlc3NTY1JzcBDxPxIgChtDbWRDaGlt";
		buffer[8] = "ZXJhRG9GaW5hbFJvdW5kQ3NSZXEQ5D8SIgodQ21kQ2hpbWVyYVJvdW5kV29y";
		buffer[9] = "a1N0YXJ0Q3NSZXEQ6T8SGwoWQ21kQ2hpbWVyYUdldERhdGFDc1JlcRDhPxIc";
		buffer[10] = "ChdFQ0dDUEtMSERFQ19BSUNPRU5FUEFDTRDiPxITCg5DbWRPSUpKRE1HT0RK";
		buffer[11] = "UBDqPxImCiFDbWRDaGltZXJhRmluaXNoRW5kbGVzc1JvdW5kQ3NSZXEQ5z8S";
		buffer[12] = "HwoaQ21kQ2hpbWVyYVF1aXRFbmRsZXNzQ3NSZXEQ6z9CFqoCE01hcmNoN3Ro";
		buffer[13] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChimeraType) }, null, null));
	}
}
