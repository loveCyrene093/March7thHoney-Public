using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournSaveBuildRefScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournSaveBuildRefScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSb2d1ZVRvdXJuU2F2ZUJ1aWxkUmVmU2NSc3AucHJvdG8iUQobUm9ndWVU" + "b3VyblNhdmVCdWlsZFJlZlNjUnNwEg8KB3JldGNvZGUYBSABKA0SDAoEbmFt" + "ZRgMIAEoCRITCgtLS0dJRUVOQ09JQxgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournSaveBuildRefScRsp), RogueTournSaveBuildRefScRsp.Parser, new string[3] { "Retcode", "Name", "KKGIEENCOIC" }, null, null, null, null)
		}));
	}
}
