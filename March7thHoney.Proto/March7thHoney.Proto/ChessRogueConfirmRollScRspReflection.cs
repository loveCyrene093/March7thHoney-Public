using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueConfirmRollScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueConfirmRollScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDaGVzc1JvZ3VlQ29uZmlybVJvbGxTY1JzcC5wcm90bxoRREZBT0lBTEVC" + "T0gucHJvdG8iUAoaQ2hlc3NSb2d1ZUNvbmZpcm1Sb2xsU2NSc3ASIQoLUEpB" + "QktEQkZQSU0YByABKAsyDC5ERkFPSUFMRUJPSBIPCgdyZXRjb2RlGA0gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DFAOIALEBOHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueConfirmRollScRsp), ChessRogueConfirmRollScRsp.Parser, new string[2] { "PJABKDBFPIM", "Retcode" }, null, null, null, null)
		}));
	}
}
