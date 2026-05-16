using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockTutorialScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockTutorialScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlVbmxvY2tUdXRvcmlhbFNjUnNwLnByb3RvGg5UdXRvcmlhbC5wcm90byJD" + "ChNVbmxvY2tUdXRvcmlhbFNjUnNwEg8KB3JldGNvZGUYASABKA0SGwoIdHV0" + "b3JpYWwYDiABKAsyCS5UdXRvcmlhbEIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { TutorialReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTutorialScRsp), UnlockTutorialScRsp.Parser, new string[2] { "Retcode", "Tutorial" }, null, null, null, null)
		}));
	}
}
