using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightHandlePendingActionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightHandlePendingActionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidHcmlkRmlnaHRIYW5kbGVQZW5kaW5nQWN0aW9uU2NSc3AucHJvdG8iTAoh" + "R3JpZEZpZ2h0SGFuZGxlUGVuZGluZ0FjdGlvblNjUnNwEhYKDnF1ZXVlX3Bv" + "c2l0aW9uGAUgASgNEg8KB3JldGNvZGUYCSABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightHandlePendingActionScRsp), GridFightHandlePendingActionScRsp.Parser, new string[2] { "QueuePosition", "Retcode" }, null, null, null, null)
		}));
	}
}
