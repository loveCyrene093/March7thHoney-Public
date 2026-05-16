using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateSyncPendingActionScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateSyncPendingActionScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNGYXRlU3luY1BlbmRpbmdBY3Rpb25TY05vdGlmeS5wcm90bxoRREZBSE1C" + "T0dNQU4ucHJvdG8iRQodRmF0ZVN5bmNQZW5kaW5nQWN0aW9uU2NOb3RpZnkS" + "JAoOcGVuZGluZ19hY3Rpb24YCiABKAsyDC5ERkFITUJPR01BTkIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DFAHMBOGMANReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateSyncPendingActionScNotify), FateSyncPendingActionScNotify.Parser, new string[1] { "PendingAction" }, null, null, null, null)
		}));
	}
}
