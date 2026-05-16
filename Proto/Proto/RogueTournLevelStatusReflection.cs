using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournLevelStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournLevelStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtSb2d1ZVRvdXJuTGV2ZWxTdGF0dXMucHJvdG8qiwEKFVJvZ3VlVG91cm5M";
		buffer[1] = "ZXZlbFN0YXR1cxIbChdKUFBJRUtPQlBJSV9QQ1BESEVMUEtFTRAAEhsKF0pQ";
		buffer[2] = "UElFS09CUElJX0hQSkVCRkZISk5QEAESGwoXSlBQSUVLT0JQSUlfUE9PTEFH";
		buffer[3] = "SEdDTUcQAhIbChdKUFBJRUtPQlBJSV9FTUVETlBDQ05ESBADQhaqAhNNYXJj";
		buffer[4] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RogueTournLevelStatus) }, null, null));
	}
}
