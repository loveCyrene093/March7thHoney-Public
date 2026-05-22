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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFHRk9JT0lBQ0RDSC5wcm90bxoRR0NPSUZBSFBHREYucHJvdG8aEU1DUFBJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RUpFQkVGLnByb3RvImgKC0dGT0lPSUFDRENIEiEKC0RNR0NJREdLUEZGGAYg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgLMgwuTUNQUElFSkVCRUYSEwoLUEFJQktPTVBGT0UYByABKA0SIQoLS1BE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SENQQ0NQTkEYCyABKAsyDC5HQ09JRkFIUEdERkIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GCOIFAHPGDFReflection.Descriptor,
			MCPPIEJEBEFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GFOIOIACDCH), GFOIOIACDCH.Parser, new string[3] { "DMGCIDGKPFF", "PAIBKOMPFOE", "KPDHCPCCPNA" }, null, null, null, null)
		}));
	}
}
