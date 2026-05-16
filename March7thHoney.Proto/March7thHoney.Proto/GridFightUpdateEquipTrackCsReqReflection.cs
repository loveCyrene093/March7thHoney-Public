using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUpdateEquipTrackCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUpdateEquipTrackCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiRHcmlkRmlnaHRVcGRhdGVFcXVpcFRyYWNrQ3NSZXEucHJvdG8aEURGS0dF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Q0xCQ0RLLnByb3RvGh9HcmlkRmlnaHRFcXVpcFRyYWNrU291cmNlLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "Im8KHkdyaWRGaWdodFVwZGF0ZUVxdWlwVHJhY2tDc1JlcRIhCgtCRVBFS0xQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QUhNQxgDIAMoCzIMLkRGS0dFQ0xCQ0RLEioKBnNvdXJjZRgPIAEoDjIaLkdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "aWRGaWdodEVxdWlwVHJhY2tTb3VyY2VCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			DFKGECLBCDKReflection.Descriptor,
			GridFightEquipTrackSourceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUpdateEquipTrackCsReq), GridFightUpdateEquipTrackCsReq.Parser, new string[2] { "BEPEKLPAHMC", "Source" }, null, null, null, null)
		}));
	}
}
