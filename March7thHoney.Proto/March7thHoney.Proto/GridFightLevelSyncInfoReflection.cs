using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightLevelSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightLevelSyncInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChxHcmlkRmlnaHRMZXZlbFN5bmNJbmZvLnByb3RvGhhHcmlkRmlnaHRMYXll";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ckluZm8ucHJvdG8idQoWR3JpZEZpZ2h0TGV2ZWxTeW5jSW5mbxISCgpzZWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "aW9uX2lkGAEgASgNEhMKC0RDUEtQTkxLR01NGAMgASgNEjIKFWdyaWRfZmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aHRfbGF5ZXJfaW5mbxgIIAEoCzITLkdyaWRGaWdodExheWVySW5mb0IWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GridFightLayerInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightLevelSyncInfo), GridFightLevelSyncInfo.Parser, new string[3] { "SectionId", "DCPKPNLKGMM", "GridFightLayerInfo" }, null, null, null, null)
		}));
	}
}
