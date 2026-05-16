using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JEEMHKBFMFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JEEMHKBFMFGReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFKRUVNSEtCRk1GRy5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8aEU5CRkRL";
		buffer[1] = "TU5HQktELnByb3RvIqcBCgtKRUVNSEtCRk1GRxITCgtNRUdDQUdOSE1JRRgC";
		buffer[2] = "IAEoDRITCgtDR09BQkdLQ0JFRhgEIAEoDRIhCgtES0tCQU1OTUZMSRgFIAMo";
		buffer[3] = "CzIMLk5CRkRLTU5HQktEEhMKC0VOSE9JTUxJQkpOGAggASgNEiEKC0FBQ0RL";
		buffer[4] = "R0tFQ0FIGAsgAygLMgwuR0tERUtKS09JSk4SEwoLREpFRlBIREZBQ08YDiAB";
		buffer[5] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GKDEKJKOIJNReflection.Descriptor,
			NBFDKMNGBKDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JEEMHKBFMFG), JEEMHKBFMFG.Parser, new string[6] { "MEGCAGNHMIE", "CGOABGKCBEF", "DKKBAMNMFLI", "ENHOIMLIBJN", "AACDKGKECAH", "DJEFPHDFACO" }, null, null, null, null)
		}));
	}
}
