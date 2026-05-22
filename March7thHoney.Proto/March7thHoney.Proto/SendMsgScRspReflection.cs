using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SendMsgScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SendMsgScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJTZW5kTXNnU2NSc3AucHJvdG8iMQoMU2VuZE1zZ1NjUnNwEhAKCGVuZF90" + "aW1lGAIgASgEEg8KB3JldGNvZGUYByABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SendMsgScRsp), SendMsgScRsp.Parser, new string[2] { "EndTime", "Retcode" }, null, null, null, null)
		}));
	}
}
