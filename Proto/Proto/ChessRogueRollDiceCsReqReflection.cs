using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueRollDiceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueRollDiceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGVzc1JvZ3VlUm9sbERpY2VDc1JlcS5wcm90byIuChdDaGVzc1JvZ3Vl" + "Um9sbERpY2VDc1JlcRITCgtCR1BCSU1EQ0JCTBgIIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueRollDiceCsReq), ChessRogueRollDiceCsReq.Parser, new string[1] { "BGPBIMDCBBL" }, null, null, null, null)
		}));
	}
}
