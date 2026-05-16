using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishTutorialScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishTutorialScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGaW5pc2hUdXRvcmlhbFNjUnNwLnByb3RvGg5UdXRvcmlhbC5wcm90byJD" + "ChNGaW5pc2hUdXRvcmlhbFNjUnNwEg8KB3JldGNvZGUYBSABKA0SGwoIdHV0" + "b3JpYWwYByABKAsyCS5UdXRvcmlhbEIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { TutorialReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishTutorialScRsp), FinishTutorialScRsp.Parser, new string[2] { "Retcode", "Tutorial" }, null, null, null, null)
		}));
	}
}
