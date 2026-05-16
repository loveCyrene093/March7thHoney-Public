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
		buffer[0] = "ChxHcmlkRmlnaHRMZXZlbFN5bmNJbmZvLnByb3RvGhhHcmlkRmlnaHRMYXll";
		buffer[1] = "ckluZm8ucHJvdG8idQoWR3JpZEZpZ2h0TGV2ZWxTeW5jSW5mbxISCgpzZWN0";
		buffer[2] = "aW9uX2lkGAEgASgNEhMKC0RDUEtQTkxLR01NGAMgASgNEjIKFWdyaWRfZmln";
		buffer[3] = "aHRfbGF5ZXJfaW5mbxgIIAEoCzITLkdyaWRGaWdodExheWVySW5mb0IWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightLayerInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightLevelSyncInfo), GridFightLevelSyncInfo.Parser, new string[3] { "SectionId", "DCPKPNLKGMM", "GridFightLayerInfo" }, null, null, null, null)
		}));
	}
}
