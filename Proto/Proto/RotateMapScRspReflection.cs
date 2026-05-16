using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RotateMapScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RotateMapScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRSb3RhdGVNYXBTY1JzcC5wcm90bxoQTW90aW9uSW5mby5wcm90byJaCg5S" + "b3RhdGVNYXBTY1JzcBIPCgdyZXRjb2RlGAQgASgNEhsKBm1vdGlvbhgGIAEo" + "CzILLk1vdGlvbkluZm8SGgoSY2xpZW50X3Bvc192ZXJzaW9uGAkgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RotateMapScRsp), RotateMapScRsp.Parser, new string[3] { "Retcode", "Motion", "ClientPosVersion" }, null, null, null, null)
		}));
	}
}
