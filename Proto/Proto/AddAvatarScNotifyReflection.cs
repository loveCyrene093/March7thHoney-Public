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
		buffer[0] = "ChdBZGRBdmF0YXJTY05vdGlmeS5wcm90bxoXQWRkQXZhdGFyU3JjU3RhdGUu";
		buffer[1] = "cHJvdG8aDkl0ZW1MaXN0LnByb3RvIncKEUFkZEF2YXRhclNjTm90aWZ5EhkK";
		buffer[2] = "BnJld2FyZBgBIAEoCzIJLkl0ZW1MaXN0Eh8KA3NyYxgGIAEoDjISLkFkZEF2";
		buffer[3] = "YXRhclNyY1N0YXRlEg4KBmlzX25ldxgHIAEoCBIWCg5iYXNlX2F2YXRhcl9p";
		buffer[4] = "ZBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AddAvatarSrcStateReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddAvatarScNotify), AddAvatarScNotify.Parser, new string[4] { "Reward", "Src", "IsNew", "BaseAvatarId" }, null, null, null, null)
		}));
	}
}
