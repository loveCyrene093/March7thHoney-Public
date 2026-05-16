using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarPropertyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarPropertyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChRBdmF0YXJQcm9wZXJ0eS5wcm90byKCAQoOQXZhdGFyUHJvcGVydHkSDgoG";
		buffer[1] = "bWF4X2hwGAEgASgBEg4KBmF0dGFjaxgCIAEoARIPCgdkZWZlbmNlGAMgASgB";
		buffer[2] = "Eg0KBXNwZWVkGAQgASgBEg8KB2xlZnRfaHAYBSABKAESDwoHbGVmdF9zcBgG";
		buffer[3] = "IAEoARIOCgZtYXhfc3AYByABKAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarProperty), AvatarProperty.Parser, new string[7] { "MaxHp", "Attack", "Defence", "Speed", "LeftHp", "LeftSp", "MaxSp" }, null, null, null, null)
		}));
	}
}
