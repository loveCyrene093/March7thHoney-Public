using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUseConsumableCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUseConsumableCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFHcmlkRmlnaHRVc2VDb25zdW1hYmxlQ3NSZXEucHJvdG8aI0dyaWRGaWdo";
		buffer[1] = "dENvbnN1bWFibGVUYXJnZXRJbmZvLnByb3RvImUKG0dyaWRGaWdodFVzZUNv";
		buffer[2] = "bnN1bWFibGVDc1JlcRI1Cg1kaXNwbGF5X3ZhbHVlGAQgASgLMh4uR3JpZEZp";
		buffer[3] = "Z2h0Q29uc3VtYWJsZVRhcmdldEluZm8SDwoHaXRlbV9pZBgJIAEoDUIWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightConsumableTargetInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUseConsumableCsReq), GridFightUseConsumableCsReq.Parser, new string[2] { "DisplayValue", "ItemId" }, null, null, null, null)
		}));
	}
}
