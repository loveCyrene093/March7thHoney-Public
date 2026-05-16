using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEntityRefreshInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEntityRefreshInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxTY2VuZUVudGl0eVJlZnJlc2hJbmZvLnByb3RvGhVTY2VuZUVudGl0eUlu";
		buffer[1] = "Zm8ucHJvdG8igAEKFlNjZW5lRW50aXR5UmVmcmVzaEluZm8SFQoLSEJJRURB";
		buffer[2] = "SkZFTE8YBCABKA1IABIXCg1kZWxldGVfZW50aXR5GAwgASgNSAASJgoKYWRk";
		buffer[3] = "X2VudGl0eRgOIAEoCzIQLlNjZW5lRW50aXR5SW5mb0gAQg4KDHJlZnJlc2hf";
		buffer[4] = "dHlwZUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneEntityInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityRefreshInfo), SceneEntityRefreshInfo.Parser, new string[3] { "HBIEDAJFELO", "DeleteEntity", "AddEntity" }, new string[1] { "RefreshType" }, null, null, null)
		}));
	}
}
