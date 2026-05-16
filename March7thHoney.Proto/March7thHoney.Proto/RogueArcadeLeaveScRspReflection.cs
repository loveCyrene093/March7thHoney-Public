using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueArcadeLeaveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueArcadeLeaveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSb2d1ZUFyY2FkZUxlYXZlU2NSc3AucHJvdG8aEUtFRURKQklFSk9GLnBy" + "b3RvIksKFVJvZ3VlQXJjYWRlTGVhdmVTY1JzcBIhCgtBRkxKSkpGQ0JJThgI" + "IAEoCzIMLktFRURKQklFSk9GEg8KB3JldGNvZGUYDSABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { KEEDJBIEJOFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeLeaveScRsp), RogueArcadeLeaveScRsp.Parser, new string[2] { "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}
