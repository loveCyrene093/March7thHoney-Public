using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooOpCatteryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooOpCatteryScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTcGFjZVpvb09wQ2F0dGVyeVNjUnNwLnByb3RvIj4KFlNwYWNlWm9vT3BD" + "YXR0ZXJ5U2NSc3ASDwoHcmV0Y29kZRgOIAEoDRITCgtKS0xHQVBHSEJIUBgP" + "IAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooOpCatteryScRsp), SpaceZooOpCatteryScRsp.Parser, new string[2] { "Retcode", "JKLGAPGHBHP" }, null, null, null, null)
		}));
	}
}
