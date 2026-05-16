using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetQuestRecordScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetQuestRecordScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRRdWVzdFJlY29yZFNjUnNwLnByb3RvGhFKT0hQR0VER0pBRC5wcm90" + "byJJChNHZXRRdWVzdFJlY29yZFNjUnNwEg8KB3JldGNvZGUYBSABKA0SIQoL" + "TEVHTkVISFBERUkYDCADKAsyDC5KT0hQR0VER0pBREIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JOHPGEDGJADReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetQuestRecordScRsp), GetQuestRecordScRsp.Parser, new string[2] { "Retcode", "LEGNEHHPDEI" }, null, null, null, null)
		}));
	}
}
