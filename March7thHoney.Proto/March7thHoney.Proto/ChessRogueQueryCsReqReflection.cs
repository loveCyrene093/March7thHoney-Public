using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueQueryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueQueryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDaGVzc1JvZ3VlUXVlcnlDc1JlcS5wcm90byIWChRDaGVzc1JvZ3VlUXVl" + "cnlDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQueryCsReq), ChessRogueQueryCsReq.Parser, null, null, null, null, null)
		}));
	}
}
