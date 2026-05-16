using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MotionInfoSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MotionInfoSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNb3Rpb25JbmZvU25hcHNob3QucHJvdG8aFFZlY3RvclNuYXBzaG90LnBy" + "b3RvIlAKEk1vdGlvbkluZm9TbmFwc2hvdBIcCgNwb3MYASABKAsyDy5WZWN0" + "b3JTbmFwc2hvdBIcCgNyb3QYAiABKAsyDy5WZWN0b3JTbmFwc2hvdEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { VectorSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MotionInfoSnapshot), MotionInfoSnapshot.Parser, new string[2] { "Pos", "Rot" }, null, null, null, null)
		}));
	}
}
