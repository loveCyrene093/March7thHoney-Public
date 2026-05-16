using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyBuildSelfDisplayAreaDiyScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyBuildSelfDisplayAreaDiyScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ci9UcmFpblBhcnR5QnVpbGRTZWxmRGlzcGxheUFyZWFEaXlTY05vdGlmeS5w";
		buffer[1] = "cm90bxoUVHJhaW5QYXJ0eUluZm8ucHJvdG8iVgopVHJhaW5QYXJ0eUJ1aWxk";
		buffer[2] = "U2VsZkRpc3BsYXlBcmVhRGl5U2NOb3RpZnkSKQoQdHJhaW5fcGFydHlfZGF0";
		buffer[3] = "YRgMIAEoCzIPLlRyYWluUGFydHlJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { TrainPartyInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyBuildSelfDisplayAreaDiyScNotify), TrainPartyBuildSelfDisplayAreaDiyScNotify.Parser, new string[1] { "TrainPartyData" }, null, null, null, null)
		}));
	}
}
