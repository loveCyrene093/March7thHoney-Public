using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddAvatarScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddAvatarScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChdBZGRBdmF0YXJTY05vdGlmeS5wcm90bxoXQWRkQXZhdGFyU3JjU3RhdGUu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cHJvdG8aDkl0ZW1MaXN0LnByb3RvIncKEUFkZEF2YXRhclNjTm90aWZ5EhkK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "BnJld2FyZBgBIAEoCzIJLkl0ZW1MaXN0Eh8KA3NyYxgGIAEoDjISLkFkZEF2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "YXRhclNyY1N0YXRlEg4KBmlzX25ldxgHIAEoCBIWCg5iYXNlX2F2YXRhcl9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			AddAvatarSrcStateReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddAvatarScNotify), AddAvatarScNotify.Parser, new string[4] { "Reward", "Src", "IsNew", "BaseAvatarId" }, null, null, null, null)
		}));
	}
}
