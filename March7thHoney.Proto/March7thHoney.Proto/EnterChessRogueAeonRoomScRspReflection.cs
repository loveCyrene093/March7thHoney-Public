using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterChessRogueAeonRoomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterChessRogueAeonRoomScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFbnRlckNoZXNzUm9ndWVBZW9uUm9vbVNjUnNwLnByb3RvGhFFSkNDSEhB" + "QUdOSC5wcm90byJRChxFbnRlckNoZXNzUm9ndWVBZW9uUm9vbVNjUnNwEg8K" + "B3JldGNvZGUYASABKA0SIAoKc3RhZ2VfaW5mbxgDIAEoCzIMLkVKQ0NISEFB" + "R05IQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { EJCCHHAAGNHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterChessRogueAeonRoomScRsp), EnterChessRogueAeonRoomScRsp.Parser, new string[2] { "Retcode", "StageInfo" }, null, null, null, null)
		}));
	}
}
