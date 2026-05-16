using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraQuitEndlessCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraQuitEndlessCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGltZXJhUXVpdEVuZGxlc3NDc1JlcS5wcm90byIZChdDaGltZXJhUXVp" + "dEVuZGxlc3NDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraQuitEndlessCsReq), ChimeraQuitEndlessCsReq.Parser, null, null, null, null, null)
		}));
	}
}
