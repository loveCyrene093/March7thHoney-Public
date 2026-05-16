using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HipplenCycleResultScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HipplenCycleResultScNotifyReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "CiBIaXBwbGVuQ3ljbGVSZXN1bHRTY05vdGlmeS5wcm90bxoRREdLTkRNQUhN";
		buffer[1] = "QVAucHJvdG8aEU9CQ0pMRERFQkhMLnByb3RvIuMBChpIaXBwbGVuQ3ljbGVS";
		buffer[2] = "ZXN1bHRTY05vdGlmeRITCgtNUEVNQkRBR0pKTxgBIAMoDRITCgtES1BDRExE";
		buffer[3] = "RE9ORxgCIAEoDRIhCgtJR05MSk5MTVBISBgHIAMoCzIMLk9CQ0pMRERFQkhM";
		buffer[4] = "EhMKC0lQT0VJR0FETEpOGAggASgNEh0KFWdyaWRfZmlnaHRfdHJhaXRfaW5m";
		buffer[5] = "bxgKIAMoDRIhCgtER0ZHTk1KQUxHShgLIAEoCzIMLkRHS05ETUFITUFQEiEK";
		buffer[6] = "C0VFTkVFUEtDSlBIGA0gAygLMgwuT0JDSkxEREVCSExCFqoCE01hcmNoN3Ro";
		buffer[7] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DGKNDMAHMAPReflection.Descriptor,
			OBCJLDDEBHLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HipplenCycleResultScNotify), HipplenCycleResultScNotify.Parser, new string[7] { "MPEMBDAGJJO", "DKPCDLDDONG", "IGNLJNLMPHH", "IPOEIGADLJN", "GridFightTraitInfo", "DGFGNMJALGJ", "EENEEPKCJPH" }, null, null, null, null)
		}));
	}
}
