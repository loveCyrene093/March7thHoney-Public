using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GHNHLNICAOIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GHNHLNICAOIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSE5ITE5JQ0FPSS5wcm90byIeCgtHSE5ITE5JQ0FPSRIPCgdyZXRjb2Rl" + "GAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GHNHLNICAOI), GHNHLNICAOI.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
