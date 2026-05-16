using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSyncUpdateResultScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSyncUpdateResultScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidHcmlkRmlnaHRTeW5jVXBkYXRlUmVzdWx0U2NOb3RpZnkucHJvdG8aHUdy";
		buffer[1] = "aWRGaWdodFN5bmNSZXN1bHREYXRhLnByb3RvIlwKIUdyaWRGaWdodFN5bmNV";
		buffer[2] = "cGRhdGVSZXN1bHRTY05vdGlmeRI3ChVzeW5jX3Jlc3VsdF9kYXRhX2xpc3QY";
		buffer[3] = "CCADKAsyGC5HcmlkRmlnaHRTeW5jUmVzdWx0RGF0YUIWqgITTWFyY2g3dGhI";
		buffer[4] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightSyncResultDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSyncUpdateResultScNotify), GridFightSyncUpdateResultScNotify.Parser, new string[1] { "SyncResultDataList" }, null, null, null, null)
		}));
	}
}
