using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueEnterCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueEnterCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDaGVzc1JvZ3VlRW50ZXJDc1JlcS5wcm90byIiChRDaGVzc1JvZ3VlRW50" + "ZXJDc1JlcRIKCgJpZBgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterCsReq), ChessRogueEnterCsReq.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
