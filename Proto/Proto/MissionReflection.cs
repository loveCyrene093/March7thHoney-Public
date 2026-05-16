using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg1NaXNzaW9uLnByb3RvGhNNaXNzaW9uU3RhdHVzLnByb3RvIkcKB01pc3Np" + "b24SCgoCaWQYBSABKA0SHgoGc3RhdHVzGAwgASgOMg4uTWlzc2lvblN0YXR1" + "cxIQCghwcm9ncmVzcxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MissionStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Mission), Mission.Parser, new string[3] { "Id", "Status", "Progress" }, null, null, null, null)
		}));
	}
}
