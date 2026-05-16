using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NIBAINNLCBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NIBAINNLCBGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSUJBSU5OTENCRy5wcm90byIeCgtOSUJBSU5OTENCRxIPCgdyZXRjb2Rl" + "GAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NIBAINNLCBG), NIBAINNLCBG.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
