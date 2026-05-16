using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSyncVirtualItemNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSyncVirtualItemNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHcmlkRmlnaHRTeW5jVmlydHVhbEl0ZW1Ob3RpZnkucHJvdG8aEVBJSUFC" + "RUhOTURELnByb3RvIkEKHkdyaWRGaWdodFN5bmNWaXJ0dWFsSXRlbU5vdGlm" + "eRIfCglpdGVtX2xpc3QYCCADKAsyDC5QSUlBQkVITk1EREIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PIIABEHNMDDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSyncVirtualItemNotify), GridFightSyncVirtualItemNotify.Parser, new string[1] { "ItemList" }, null, null, null, null)
		}));
	}
}
