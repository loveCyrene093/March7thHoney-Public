using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MGEMFGLDJLJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MGEMFGLDJLJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNR0VNRkdMREpMSi5wcm90byIrCgtNR0VNRkdMREpMShIPCgdyb2xlX2lk" + "GAggASgNEgsKA251bRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MGEMFGLDJLJ), MGEMFGLDJLJ.Parser, new string[2] { "RoleId", "Num" }, null, null, null, null)
		}));
	}
}
