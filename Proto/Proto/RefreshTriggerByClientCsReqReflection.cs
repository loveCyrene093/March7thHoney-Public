using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RefreshTriggerByClientCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RefreshTriggerByClientCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiFSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50Q3NSZXEucHJvdG8aEE1vdGlvbklu";
		buffer[1] = "Zm8ucHJvdG8iqAEKG1JlZnJlc2hUcmlnZ2VyQnlDbGllbnRDc1JlcRITCgtp";
		buffer[2] = "bnRlcmFjdF9pZBgBIAEoBBIeChZ0cmlnZ2VyX3RhcmdldF9pZF9saXN0GAIg";
		buffer[3] = "AygNEhQKDHRyaWdnZXJfbmFtZRgFIAEoCRIZChF0cmlnZ2VyX2VudGl0eV9p";
		buffer[4] = "ZBgHIAEoDRIjCg50cmlnZ2VyX21vdGlvbhgNIAEoCzILLk1vdGlvbkluZm9C";
		buffer[5] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RefreshTriggerByClientCsReq), RefreshTriggerByClientCsReq.Parser, new string[5] { "InteractId", "TriggerTargetIdList", "TriggerName", "TriggerEntityId", "TriggerMotion" }, null, null, null, null)
		}));
	}
}
