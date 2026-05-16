using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMJBMFHCOFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMJBMFHCOFIReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFDTUpCTUZIQ09GSS5wcm90bxoRQU5ITEZDSkdQRUUucHJvdG8aEVBHT0dQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "T0hFSUVHLnByb3RvIpEBCgtDTUpCTUZIQ09GSRITCgtISk1HR0xBTkhNTBgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAEoDRISCgptb25zdGVyX2lkGAIgASgNEiEKC1BFQ0lMSU5FTE5HGAMgAygL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "MgwuQU5ITEZDSkdQRUUSEwoLSkhGS0FOS0dMSk4YBCABKA0SIQoLTktCQVBK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "UEhKRlAYBSADKAsyDC5QR09HUE9IRUlFR0IWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			ANHLFCJGPEEReflection.Descriptor,
			PGOGPOHEIEGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMJBMFHCOFI), CMJBMFHCOFI.Parser, new string[5] { "HJMGGLANHML", "MonsterId", "PECILINELNG", "JHFKANKGLJN", "NKBAPJPHJFP" }, null, null, null, null)
		}));
	}
}
