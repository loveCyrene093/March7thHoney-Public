using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueRollDiceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueRollDiceScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGVzc1JvZ3VlUm9sbERpY2VTY1JzcC5wcm90bxoRREZBT0lBTEVCT0gu" + "cHJvdG8iTQoXQ2hlc3NSb2d1ZVJvbGxEaWNlU2NSc3ASIQoLUEpBQktEQkZQ" + "SU0YCiABKAsyDC5ERkFPSUFMRUJPSBIPCgdyZXRjb2RlGA8gASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DFAOIALEBOHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueRollDiceScRsp), ChessRogueRollDiceScRsp.Parser, new string[2] { "PJABKDBFPIM", "Retcode" }, null, null, null, null)
		}));
	}
}
