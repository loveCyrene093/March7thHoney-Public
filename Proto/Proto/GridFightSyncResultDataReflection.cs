using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSyncResultDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSyncResultDataReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch1HcmlkRmlnaHRTeW5jUmVzdWx0RGF0YS5wcm90bxoXR3JpZEZpZ2h0U3lu";
		buffer[1] = "Y0RhdGEucHJvdG8aHEdyaWRGaWdodFVwZGF0ZVNyY1R5cGUucHJvdG8inAEK";
		buffer[2] = "F0dyaWRGaWdodFN5bmNSZXN1bHREYXRhEi8KE3VwZGF0ZV9keW5hbWljX2xp";
		buffer[3] = "c3QYBCADKAsyEi5HcmlkRmlnaHRTeW5jRGF0YRIeChZzeW5jX2VmZmVjdF9w";
		buffer[4] = "YXJhbV9saXN0GAcgAygNEjAKD2dyaWRfdXBkYXRlX3NyYxgNIAEoDjIXLkdy";
		buffer[5] = "aWRGaWdodFVwZGF0ZVNyY1R5cGVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[6] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GridFightSyncDataReflection.Descriptor,
			GridFightUpdateSrcTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSyncResultData), GridFightSyncResultData.Parser, new string[3] { "UpdateDynamicList", "SyncEffectParamList", "GridUpdateSrc" }, null, null, null, null)
		}));
	}
}
