using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AHNGIOFDJNLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AHNGIOFDJNLReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChFBSE5HSU9GREpOTC5wcm90bxoRQkdLRE9PSkFIQU0ucHJvdG8aEUtKQUdM";
		buffer[1] = "SUlEQkdQLnByb3RvGhFNQUdIRUZFRUxBQi5wcm90bxoRTkRQR0tETEdCRkIu";
		buffer[2] = "cHJvdG8aEU5KSU5DTkFHQUxQLnByb3RvGhFQTkNCR0dKS0tBRi5wcm90byLz";
		buffer[3] = "AQoLQUhOR0lPRkRKTkwSIQoLQkZISkhBS0ZCSUcYAiADKAsyDC5NQUdIRUZF";
		buffer[4] = "RUxBQhITCgtOREdERUtFQUZDQxgFIAMoDRIgCgpzdG9yeV9pbmZvGAcgASgL";
		buffer[5] = "MgwuQkdLRE9PSkFIQU0SIQoLSkpBQUJMQ01GTFAYCSADKAsyDC5QTkNCR0dK";
		buffer[6] = "S0tBRhIhCgtOSVBDRUFGTENBQRgLIAMoCzIMLk5EUEdLRExHQkZCEiEKC0NM";
		buffer[7] = "TEdIRENOUE9JGA0gASgLMgwuS0pBR0xJSURCR1ASIQoLQklDUE5LT0NIR04Y";
		buffer[8] = "DyADKAsyDC5OSklOQ05BR0FMUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[9] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[6]
		{
			BGKDOOJAHAMReflection.Descriptor,
			KJAGLIIDBGPReflection.Descriptor,
			MAGHEFEELABReflection.Descriptor,
			NDPGKDLGBFBReflection.Descriptor,
			NJINCNAGALPReflection.Descriptor,
			PNCBGGJKKAFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AHNGIOFDJNL), AHNGIOFDJNL.Parser, new string[7] { "BFHJHAKFBIG", "NDGDEKEAFCC", "StoryInfo", "JJAABLCMFLP", "NIPCEAFLCAA", "CLLGHDCNPOI", "BICPNKOCHGN" }, null, null, null, null)
		}));
	}
}
