using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueReRollDiceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueReRollDiceScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVzc1JvZ3VlUmVSb2xsRGljZVNjUnNwLnByb3RvGhFERkFPSUFMRUJP" + "SC5wcm90byJPChlDaGVzc1JvZ3VlUmVSb2xsRGljZVNjUnNwEg8KB3JldGNv" + "ZGUYCiABKA0SIQoLUEpBQktEQkZQSU0YCyABKAsyDC5ERkFPSUFMRUJPSEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DFAOIALEBOHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueReRollDiceScRsp), ChessRogueReRollDiceScRsp.Parser, new string[2] { "Retcode", "PJABKDBFPIM" }, null, null, null, null)
		}));
	}
}
