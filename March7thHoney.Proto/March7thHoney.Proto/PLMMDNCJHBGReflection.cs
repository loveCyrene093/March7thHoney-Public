using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLMMDNCJHBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLMMDNCJHBGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTE1NRE5DSkhCRy5wcm90byIeCgtQTE1NRE5DSkhCRxIPCgdyZXRjb2Rl" + "GAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PLMMDNCJHBG), PLMMDNCJHBG.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
