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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChRBdmF0YXJQcm9wZXJ0eS5wcm90byKCAQoOQXZhdGFyUHJvcGVydHkSDgoG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bWF4X2hwGAEgASgBEg4KBmF0dGFjaxgCIAEoARIPCgdkZWZlbmNlGAMgASgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Eg0KBXNwZWVkGAQgASgBEg8KB2xlZnRfaHAYBSABKAESDwoHbGVmdF9zcBgG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoARIOCgZtYXhfc3AYByABKAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarProperty), AvatarProperty.Parser, new string[7] { "MaxHp", "Attack", "Defence", "Speed", "LeftHp", "LeftSp", "MaxSp" }, null, null, null, null)
		}));
	}
}
