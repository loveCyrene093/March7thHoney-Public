using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ApplyFriendScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ApplyFriendScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBcHBseUZyaWVuZFNjUnNwLnByb3RvIjAKEEFwcGx5RnJpZW5kU2NSc3AS" + "CwoDdWlkGAMgASgNEg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ApplyFriendScRsp), ApplyFriendScRsp.Parser, new string[2] { "Uid", "Retcode" }, null, null, null, null)
		}));
	}
}
