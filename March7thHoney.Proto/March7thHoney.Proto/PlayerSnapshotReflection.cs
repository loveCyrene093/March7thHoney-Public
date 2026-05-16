using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRQbGF5ZXJTbmFwc2hvdC5wcm90bxoYTW90aW9uSW5mb1NuYXBzaG90LnBy" + "b3RvIk0KDlBsYXllclNuYXBzaG90EigKC21vdGlvbl9pbmZvGAEgASgLMhMu" + "TW90aW9uSW5mb1NuYXBzaG90EhEKCW1hcF9sYXllchgCIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MotionInfoSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerSnapshot), PlayerSnapshot.Parser, new string[2] { "MotionInfo", "MapLayer" }, null, null, null, null)
		}));
	}
}
