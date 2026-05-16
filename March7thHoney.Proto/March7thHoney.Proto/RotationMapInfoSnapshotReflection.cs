using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RotationMapInfoSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RotationMapInfoSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb3RhdGlvbk1hcEluZm9TbmFwc2hvdC5wcm90bxoUVmVjdG9yU25hcHNo" + "b3QucHJvdG8iXQoXUm90YXRpb25NYXBJbmZvU25hcHNob3QSIAoHbWFwX3Bv" + "cxgBIAEoCzIPLlZlY3RvclNuYXBzaG90EiAKB21hcF9yb3QYAiABKAsyDy5W" + "ZWN0b3JTbmFwc2hvdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { VectorSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RotationMapInfoSnapshot), RotationMapInfoSnapshot.Parser, new string[2] { "MapPos", "MapRot" }, null, null, null, null)
		}));
	}
}
