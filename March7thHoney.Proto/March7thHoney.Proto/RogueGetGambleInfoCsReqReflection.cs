using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueGetGambleInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueGetGambleInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb2d1ZUdldEdhbWJsZUluZm9Dc1JlcS5wcm90byIxChdSb2d1ZUdldEdh" + "bWJsZUluZm9Dc1JlcRIWCg5wcm9wX2VudGl0eV9pZBgHIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueGetGambleInfoCsReq), RogueGetGambleInfoCsReq.Parser, new string[1] { "PropEntityId" }, null, null, null, null)
		}));
	}
}
