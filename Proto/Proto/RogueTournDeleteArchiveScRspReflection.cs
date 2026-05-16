using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournDeleteArchiveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournDeleteArchiveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuRGVsZXRlQXJjaGl2ZVNjUnNwLnByb3RvIkQKHFJvZ3Vl" + "VG91cm5EZWxldGVBcmNoaXZlU2NSc3ASEwoLS0tHSUVFTkNPSUMYAyABKA0S" + "DwoHcmV0Y29kZRgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournDeleteArchiveScRsp), RogueTournDeleteArchiveScRsp.Parser, new string[2] { "KKGIEENCOIC", "Retcode" }, null, null, null, null)
		}));
	}
}
