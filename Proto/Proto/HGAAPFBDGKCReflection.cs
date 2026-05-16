using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HGAAPFBDGKCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HGAAPFBDGKCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIR0FBUEZCREdLQy5wcm90byIeCgtIR0FBUEZCREdLQxIPCgdyZXRjb2Rl" + "GAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HGAAPFBDGKC), HGAAPFBDGKC.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
