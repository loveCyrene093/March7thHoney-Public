using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueConfirmRollCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueConfirmRollCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDaGVzc1JvZ3VlQ29uZmlybVJvbGxDc1JlcS5wcm90byIxChpDaGVzc1Jv" + "Z3VlQ29uZmlybVJvbGxDc1JlcRITCgtCR1BCSU1EQ0JCTBgCIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueConfirmRollCsReq), ChessRogueConfirmRollCsReq.Parser, new string[1] { "BGPBIMDCBBL" }, null, null, null, null)
		}));
	}
}
