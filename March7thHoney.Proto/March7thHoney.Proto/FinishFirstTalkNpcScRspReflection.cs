using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishFirstTalkNpcScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishFirstTalkNpcScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1GaW5pc2hGaXJzdFRhbGtOcGNTY1JzcC5wcm90byI6ChdGaW5pc2hGaXJz" + "dFRhbGtOcGNTY1JzcBIPCgdyZXRjb2RlGAIgASgNEg4KBm5wY19pZBgMIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishFirstTalkNpcScRsp), FinishFirstTalkNpcScRsp.Parser, new string[2] { "Retcode", "NpcId" }, null, null, null, null)
		}));
	}
}
