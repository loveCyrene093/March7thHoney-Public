using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateFiveDimGameDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateFiveDimGameDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBVcGRhdGVGaXZlRGltR2FtZURhdGFTY1JzcC5wcm90byItChpVcGRhdGVG" + "aXZlRGltR2FtZURhdGFTY1JzcBIPCgdyZXRjb2RlGAUgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateFiveDimGameDataScRsp), UpdateFiveDimGameDataScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
