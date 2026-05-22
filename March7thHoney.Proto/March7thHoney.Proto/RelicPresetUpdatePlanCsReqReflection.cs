using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicPresetUpdatePlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicPresetUpdatePlanCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBSZWxpY1ByZXNldFVwZGF0ZVBsYW5Dc1JlcS5wcm90bxoRRFBERExBT0JN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QkgucHJvdG8icgoaUmVsaWNQcmVzZXRVcGRhdGVQbGFuQ3NSZXESEQoJdW5p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "cXVlX2lkGAogASgNEiIKCnJlbGljX2xpc3QYAyABKAsyDC5EUERETEFPQk1C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SEgAEg4KBG5hbWUYDiABKAlIAEINCgtCUElIRkFKQ0xPQ0IWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { DPDDLAOBMBHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicPresetUpdatePlanCsReq), RelicPresetUpdatePlanCsReq.Parser, new string[3] { "UniqueId", "RelicList", "Name" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
