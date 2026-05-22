using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNNNKIJPMIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNNNKIJPMIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTk5OS0lKUE1JSS5wcm90byIeCgtGTk5OS0lKUE1JSRIPCgdyZXRjb2Rl" + "GAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNNNKIJPMII), FNNNKIJPMII.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
