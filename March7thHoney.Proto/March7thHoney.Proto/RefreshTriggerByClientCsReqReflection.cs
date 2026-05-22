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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiFSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50Q3NSZXEucHJvdG8aEE1vdGlvbklu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Zm8ucHJvdG8iqAEKG1JlZnJlc2hUcmlnZ2VyQnlDbGllbnRDc1JlcRITCgtp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bnRlcmFjdF9pZBgBIAEoBBIeChZ0cmlnZ2VyX3RhcmdldF9pZF9saXN0GAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "AygNEhQKDHRyaWdnZXJfbmFtZRgFIAEoCRIZChF0cmlnZ2VyX2VudGl0eV9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ZBgHIAEoDRIjCg50cmlnZ2VyX21vdGlvbhgNIAEoCzILLk1vdGlvbkluZm9C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RefreshTriggerByClientCsReq), RefreshTriggerByClientCsReq.Parser, new string[5] { "InteractId", "TriggerTargetIdList", "TriggerName", "TriggerEntityId", "TriggerMotion" }, null, null, null, null)
		}));
	}
}
