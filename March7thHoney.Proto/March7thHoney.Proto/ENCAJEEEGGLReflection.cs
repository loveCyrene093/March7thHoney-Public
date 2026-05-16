using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ENCAJEEEGGLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ENCAJEEEGGLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTkNBSkVFRUdHTC5wcm90byIeCgtFTkNBSkVFRUdHTBIPCgdyZXRjb2Rl" + "GAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ENCAJEEEGGL), ENCAJEEEGGL.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
