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
		buffer[0] = "ChlNdWx0aVBhdGhBdmF0YXJUeXBlLnByb3RvKrICChNNdWx0aVBhdGhBdmF0";
		buffer[1] = "YXJUeXBlEhsKF011bHRpUGF0aEF2YXRhclR5cGVOb25lEAASFgoRTWFyXzd0";
		buffer[2] = "aEtuaWdodFR5cGUQ6QcSFQoQTWFyXzd0aFJvZ3VlVHlwZRDICRITCg5Cb3lX";
		buffer[3] = "YXJyaW9yVHlwZRDBPhIUCg9HaXJsV2FycmlvclR5cGUQwj4SEgoNQm95S25p";
		buffer[4] = "Z2h0VHlwZRDDPhITCg5HaXJsS25pZ2h0VHlwZRDEPhISCg1Cb3lTaGFtYW5U";
		buffer[5] = "eXBlEMU+EhMKDkdpcmxTaGFtYW5UeXBlEMY+EhIKDUJveU1lbW9yeVR5cGUQ";
		buffer[6] = "xz4SEwoOR2lybE1lbW9yeVR5cGUQyD4SEwoOQm95RWxhdGlvblR5cGUQyT4S";
		buffer[7] = "FAoPR2lybEVsYXRpb25UeXBlEMo+QhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[8] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MultiPathAvatarType) }, null, null));
	}
}
