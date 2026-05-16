using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueArcadeGetInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueArcadeGetInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb2d1ZUFyY2FkZUdldEluZm9Dc1JlcS5wcm90byIZChdSb2d1ZUFyY2Fk" + "ZUdldEluZm9Dc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeGetInfoCsReq), RogueArcadeGetInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
