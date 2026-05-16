using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PropInfoSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PropInfoSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZQcm9wSW5mb1NuYXBzaG90LnByb3RvIiYKEFByb3BJbmZvU25hcHNob3QS" + "EgoKcHJvcF9zdGF0ZRgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PropInfoSnapshot), PropInfoSnapshot.Parser, new string[1] { "PropState" }, null, null, null, null)
		}));
	}
}
