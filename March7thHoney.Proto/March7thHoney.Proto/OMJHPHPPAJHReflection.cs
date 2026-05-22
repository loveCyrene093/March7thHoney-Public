using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OMJHPHPPAJHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OMJHPHPPAJHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTUpIUEhQUEFKSC5wcm90byJICgtPTUpIUEhQUEFKSBITCgtGTEJGQkJK" + "SUpJSRgFIAEoCRIPCgdyZXRjb2RlGAwgASgNEhMKC0hOSElHSEdLRUNOGA8g" + "ASgJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OMJHPHPPAJH), OMJHPHPPAJH.Parser, new string[3] { "FLBFBBJIJII", "Retcode", "HNHIGHGKECN" }, null, null, null, null)
		}));
	}
}
