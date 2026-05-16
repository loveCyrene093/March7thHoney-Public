using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenHipplenCycleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenHipplenCycleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtPcGVuSGlwcGxlbkN5Y2xlQ3NSZXEucHJvdG8iKQoVT3BlbkhpcHBsZW5D" + "eWNsZUNzUmVxEhAKCHRyYWl0X2lkGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenHipplenCycleCsReq), OpenHipplenCycleCsReq.Parser, new string[1] { "TraitId" }, null, null, null, null)
		}));
	}
}
