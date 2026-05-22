using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeQuestEquipCsRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeQuestEquipCsRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlUYWtlUXVlc3RFcXVpcENzUnNwLnByb3RvIksKE1Rha2VRdWVzdEVxdWlw" + "Q3NSc3ASDwoHcmV0Y29kZRgBIAEoDRIRCglEaXNjYXJkZWQYBCABKAgSEAoI" + "cXVlc3RfaWQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestEquipCsRsp), TakeQuestEquipCsRsp.Parser, new string[3] { "Retcode", "Discarded", "QuestId" }, null, null, null, null)
		}));
	}
}
