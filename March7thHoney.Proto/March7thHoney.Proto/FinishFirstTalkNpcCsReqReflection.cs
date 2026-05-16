using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishFirstTalkNpcCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishFirstTalkNpcCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1GaW5pc2hGaXJzdFRhbGtOcGNDc1JlcS5wcm90byIpChdGaW5pc2hGaXJz" + "dFRhbGtOcGNDc1JlcRIOCgZucGNfaWQYCSABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishFirstTalkNpcCsReq), FinishFirstTalkNpcCsReq.Parser, new string[1] { "NpcId" }, null, null, null, null)
		}));
	}
}
