using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GFOIOIACDCHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GFOIOIACDCHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHRk9JT0lBQ0RDSC5wcm90bxoRR0NPSUZBSFBHREYucHJvdG8aEU1DUFBJ";
		buffer[1] = "RUpFQkVGLnByb3RvImgKC0dGT0lPSUFDRENIEiEKC0RNR0NJREdLUEZGGAYg";
		buffer[2] = "ASgLMgwuTUNQUElFSkVCRUYSEwoLUEFJQktPTVBGT0UYByABKA0SIQoLS1BE";
		buffer[3] = "SENQQ0NQTkEYCyABKAsyDC5HQ09JRkFIUEdERkIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GCOIFAHPGDFReflection.Descriptor,
			MCPPIEJEBEFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GFOIOIACDCH), GFOIOIACDCH.Parser, new string[3] { "DMGCIDGKPFF", "PAIBKOMPFOE", "KPDHCPCCPNA" }, null, null, null, null)
		}));
	}
}
