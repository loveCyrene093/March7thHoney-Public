using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GIPKOGLGHLBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GIPKOGLGHLBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSVBLT0dMR0hMQi5wcm90byIeCgtHSVBLT0dMR0hMQhIPCgdyZXRjb2Rl" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GIPKOGLGHLB), GIPKOGLGHLB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
