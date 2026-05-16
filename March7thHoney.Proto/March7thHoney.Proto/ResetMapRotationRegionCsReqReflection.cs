using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ResetMapRotationRegionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ResetMapRotationRegionCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFSZXNldE1hcFJvdGF0aW9uUmVnaW9uQ3NSZXEucHJvdG8aEE1vdGlvbklu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Zm8ucHJvdG8aE1JvdGF0ZU1hcEluZm8ucHJvdG8iXwobUmVzZXRNYXBSb3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dGlvblJlZ2lvbkNzUmVxEhsKBm1vdGlvbhgBIAEoCzILLk1vdGlvbkluZm8S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IwoLQU1NSkVDSFBHUEUYDCABKAsyDi5Sb3RhdGVNYXBJbmZvQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			MotionInfoReflection.Descriptor,
			RotateMapInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ResetMapRotationRegionCsReq), ResetMapRotationRegionCsReq.Parser, new string[2] { "Motion", "AMMJECHPGPE" }, null, null, null, null)
		}));
	}
}
