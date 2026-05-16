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
		buffer[0] = "CiRHcmlkRmlnaHRVcGRhdGVFcXVpcFRyYWNrQ3NSZXEucHJvdG8aEURGS0dF";
		buffer[1] = "Q0xCQ0RLLnByb3RvGh9HcmlkRmlnaHRFcXVpcFRyYWNrU291cmNlLnByb3Rv";
		buffer[2] = "Im8KHkdyaWRGaWdodFVwZGF0ZUVxdWlwVHJhY2tDc1JlcRIhCgtCRVBFS0xQ";
		buffer[3] = "QUhNQxgDIAMoCzIMLkRGS0dFQ0xCQ0RLEioKBnNvdXJjZRgPIAEoDjIaLkdy";
		buffer[4] = "aWRGaWdodEVxdWlwVHJhY2tTb3VyY2VCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[5] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DFKGECLBCDKReflection.Descriptor,
			GridFightEquipTrackSourceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUpdateEquipTrackCsReq), GridFightUpdateEquipTrackCsReq.Parser, new string[2] { "BEPEKLPAHMC", "Source" }, null, null, null, null)
		}));
	}
}
