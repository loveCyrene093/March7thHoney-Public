using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFirstTalkNpcScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFirstTalkNpcScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRGaXJzdFRhbGtOcGNTY1JzcC5wcm90bxoWRmlyc3ROcGNUYWxrSW5m" + "by5wcm90byJYChRHZXRGaXJzdFRhbGtOcGNTY1JzcBIvChRucGNfbWVldF9z" + "dGF0dXNfbGlzdBgEIAMoCzIRLkZpcnN0TnBjVGFsa0luZm8SDwoHcmV0Y29k" + "ZRgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FirstNpcTalkInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFirstTalkNpcScRsp), GetFirstTalkNpcScRsp.Parser, new string[2] { "NpcMeetStatusList", "Retcode" }, null, null, null, null)
		}));
	}
}
