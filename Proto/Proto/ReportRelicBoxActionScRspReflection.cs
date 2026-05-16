using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReportRelicBoxActionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReportRelicBoxActionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXBvcnRSZWxpY0JveEFjdGlvblNjUnNwLnByb3RvGhFKSEhCSU9KSEVH" + "TC5wcm90byJJChlSZXBvcnRSZWxpY0JveEFjdGlvblNjUnNwEg8KB3JldGNv" + "ZGUYBiABKA0SGwoFc3RhdGUYCSABKA4yDC5KSEhCSU9KSEVHTEIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JHHBIOJHEGLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReportRelicBoxActionScRsp), ReportRelicBoxActionScRsp.Parser, new string[2] { "Retcode", "State" }, null, null, null, null)
		}));
	}
}
