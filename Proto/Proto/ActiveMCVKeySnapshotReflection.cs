using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActiveMCVKeySnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActiveMCVKeySnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpBY3RpdmVNQ1ZLZXlTbmFwc2hvdC5wcm90byJAChRBY3RpdmVNQ1ZLZXlT" + "bmFwc2hvdBIXCg9tYWluX21pc3Npb25faWQYASABKA0SDwoHbWN2X2tleRgC" + "IAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActiveMCVKeySnapshot), ActiveMCVKeySnapshot.Parser, new string[2] { "MainMissionId", "McvKey" }, null, null, null, null)
		}));
	}
}
