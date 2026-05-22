using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetEnteredSceneScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetEnteredSceneScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRFbnRlcmVkU2NlbmVTY1JzcC5wcm90bxoWRW50ZXJlZFNjZW5lSW5m" + "by5wcm90byJbChRHZXRFbnRlcmVkU2NlbmVTY1JzcBIyChdlbnRlcmVkX3Nj" + "ZW5lX2luZm9fbGlzdBgFIAMoCzIRLkVudGVyZWRTY2VuZUluZm8SDwoHcmV0" + "Y29kZRgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { EnteredSceneInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetEnteredSceneScRsp), GetEnteredSceneScRsp.Parser, new string[2] { "EnteredSceneInfoList", "Retcode" }, null, null, null, null)
		}));
	}
}
