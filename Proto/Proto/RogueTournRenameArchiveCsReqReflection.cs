using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournRenameArchiveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournRenameArchiveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuUmVuYW1lQXJjaGl2ZUNzUmVxLnByb3RvIkEKHFJvZ3Vl" + "VG91cm5SZW5hbWVBcmNoaXZlQ3NSZXESDAoEbmFtZRgFIAEoCRITCgtLS0dJ" + "RUVOQ09JQxgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournRenameArchiveCsReq), RogueTournRenameArchiveCsReq.Parser, new string[2] { "Name", "KKGIEENCOIC" }, null, null, null, null)
		}));
	}
}
