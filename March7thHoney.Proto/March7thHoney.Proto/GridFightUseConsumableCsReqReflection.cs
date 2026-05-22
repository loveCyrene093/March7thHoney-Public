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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFHcmlkRmlnaHRVc2VDb25zdW1hYmxlQ3NSZXEucHJvdG8aI0dyaWRGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dENvbnN1bWFibGVUYXJnZXRJbmZvLnByb3RvImUKG0dyaWRGaWdodFVzZUNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bnN1bWFibGVDc1JlcRI1Cg1kaXNwbGF5X3ZhbHVlGAQgASgLMh4uR3JpZEZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Z2h0Q29uc3VtYWJsZVRhcmdldEluZm8SDwoHaXRlbV9pZBgJIAEoDUIWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GridFightConsumableTargetInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUseConsumableCsReq), GridFightUseConsumableCsReq.Parser, new string[2] { "DisplayValue", "ItemId" }, null, null, null, null)
		}));
	}
}
