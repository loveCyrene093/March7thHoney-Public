using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueArcadeRestartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueArcadeRestartCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb2d1ZUFyY2FkZVJlc3RhcnRDc1JlcS5wcm90byIZChdSb2d1ZUFyY2Fk" + "ZVJlc3RhcnRDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeRestartCsReq), RogueArcadeRestartCsReq.Parser, null, null, null, null, null)
		}));
	}
}
