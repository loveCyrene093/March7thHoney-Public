using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterFiveDimGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterFiveDimGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtFbnRlckZpdmVEaW1HYW1lU2NSc3AucHJvdG8iKAoVRW50ZXJGaXZlRGlt" + "R2FtZVNjUnNwEg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterFiveDimGameScRsp), EnterFiveDimGameScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
