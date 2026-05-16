using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChBBdmF0YXJUeXBlLnByb3RvKvYBCgpBdmF0YXJUeXBlEhQKEEFWQVRBUl9U";
		buffer[1] = "WVBFX05PTkUQABIVChFBVkFUQVJfVFJJQUxfVFlQRRABEhUKEUFWQVRBUl9M";
		buffer[2] = "SU1JVF9UWVBFEAISFgoSQVZBVEFSX0ZPUk1BTF9UWVBFEAMSFgoSQVZBVEFS";
		buffer[3] = "X0FTU0lTVF9UWVBFEAQSHQoZQVZBVEFSX0FFVEhFUl9ESVZJREVfVFlQRRAF";
		buffer[4] = "EiEKHUFWQVRBUl9VUEdSQURFX0FWQUlMQUJMRV9UWVBFEAYSGgoWQVZBVEFS";
		buffer[5] = "X0dSSURfRklHSFRfVFlQRRAHEhYKEkFWQVRBUl9HTEpETkRNSUdJUBAIQhaq";
		buffer[6] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AvatarType) }, null, null));
	}
}
