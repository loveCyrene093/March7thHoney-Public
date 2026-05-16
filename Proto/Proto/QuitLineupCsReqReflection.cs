using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuitLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuitLineupCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChVRdWl0TGluZXVwQ3NSZXEucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aFUV4";
		buffer[1] = "dHJhTGluZXVwVHlwZS5wcm90byKtAQoPUXVpdExpbmV1cENzUmVxEhAKCHBs";
		buffer[2] = "YW5lX2lkGAMgASgNEhIKCmlzX3ZpcnR1YWwYBCABKAgSDQoFaW5kZXgYBiAB";
		buffer[3] = "KA0SKwoRZXh0cmFfbGluZXVwX3R5cGUYCCABKA4yEC5FeHRyYUxpbmV1cFR5";
		buffer[4] = "cGUSFgoOYmFzZV9hdmF0YXJfaWQYCSABKA0SIAoLYXZhdGFyX3R5cGUYDSAB";
		buffer[5] = "KA4yCy5BdmF0YXJUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[6] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AvatarTypeReflection.Descriptor,
			ExtraLineupTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuitLineupCsReq), QuitLineupCsReq.Parser, new string[6] { "PlaneId", "IsVirtual", "Index", "ExtraLineupType", "BaseAvatarId", "AvatarType" }, null, null, null, null)
		}));
	}
}
