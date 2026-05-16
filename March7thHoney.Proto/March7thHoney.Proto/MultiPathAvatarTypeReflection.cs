using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MultiPathAvatarTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MultiPathAvatarTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChlNdWx0aVBhdGhBdmF0YXJUeXBlLnByb3RvKrICChNNdWx0aVBhdGhBdmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "YXJUeXBlEhsKF011bHRpUGF0aEF2YXRhclR5cGVOb25lEAASFgoRTWFyXzd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "aEtuaWdodFR5cGUQ6QcSFQoQTWFyXzd0aFJvZ3VlVHlwZRDICRITCg5Cb3lX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "YXJyaW9yVHlwZRDBPhIUCg9HaXJsV2FycmlvclR5cGUQwj4SEgoNQm95S25p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "Z2h0VHlwZRDDPhITCg5HaXJsS25pZ2h0VHlwZRDEPhISCg1Cb3lTaGFtYW5U";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "eXBlEMU+EhMKDkdpcmxTaGFtYW5UeXBlEMY+EhIKDUJveU1lbW9yeVR5cGUQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "xz4SEwoOR2lybE1lbW9yeVR5cGUQyD4SEwoOQm95RWxhdGlvblR5cGUQyT4S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "FAoPR2lybEVsYXRpb25UeXBlEMo+QhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MultiPathAvatarType) }, null, null));
	}
}
