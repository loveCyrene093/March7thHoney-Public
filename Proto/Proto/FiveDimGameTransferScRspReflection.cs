using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FiveDimGameTransferScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FiveDimGameTransferScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5GaXZlRGltR2FtZVRyYW5zZmVyU2NSc3AucHJvdG8iKwoYRml2ZURpbUdh" + "bWVUcmFuc2ZlclNjUnNwEg8KB3JldGNvZGUYBCABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FiveDimGameTransferScRsp), FiveDimGameTransferScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
