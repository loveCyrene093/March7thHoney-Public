using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GEAPPKGNLJGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GEAPPKGNLJGReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFHRUFQUEtHTkxKRy5wcm90bxoRSE1KR0FETElPTkEucHJvdG8aEE1vdGlv";
		buffer[1] = "bkluZm8ucHJvdG8aEU5NSEtETEpQR0lMLnByb3RvInUKC0dFQVBQS0dOTEpH";
		buffer[2] = "EiEKC1BQUEhMSEFEQ1BKGAEgASgLMgwuSE1KR0FETElPTkESIQoLTU9ERElC";
		buffer[3] = "SENQUEQYAyABKAsyDC5OTUhLRExKUEdJTBIgCgtNSkRNTkRJRUtISxgFIAEo";
		buffer[4] = "CzILLk1vdGlvbkluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[5] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			HMJGADLIONAReflection.Descriptor,
			MotionInfoReflection.Descriptor,
			NMHKDLJPGILReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GEAPPKGNLJG), GEAPPKGNLJG.Parser, new string[3] { "PPPHLHADCPJ", "MODDIBHCPPD", "MJDMNDIEKHK" }, null, null, null, null)
		}));
	}
}
