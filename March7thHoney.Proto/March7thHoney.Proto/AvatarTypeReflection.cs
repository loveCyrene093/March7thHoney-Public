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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChBBdmF0YXJUeXBlLnByb3RvKvYBCgpBdmF0YXJUeXBlEhQKEEFWQVRBUl9U";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "WVBFX05PTkUQABIVChFBVkFUQVJfVFJJQUxfVFlQRRABEhUKEUFWQVRBUl9M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "SU1JVF9UWVBFEAISFgoSQVZBVEFSX0ZPUk1BTF9UWVBFEAMSFgoSQVZBVEFS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "X0FTU0lTVF9UWVBFEAQSHQoZQVZBVEFSX0FFVEhFUl9ESVZJREVfVFlQRRAF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "EiEKHUFWQVRBUl9VUEdSQURFX0FWQUlMQUJMRV9UWVBFEAYSGgoWQVZBVEFS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "X0dSSURfRklHSFRfVFlQRRAHEhYKEkFWQVRBUl9HTEpETkRNSUdJUBAIQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AvatarType) }, null, null));
	}
}
