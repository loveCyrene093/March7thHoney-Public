using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarSyncReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarSyncReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChBBdmF0YXJTeW5jLnByb3RvGgxBdmF0YXIucHJvdG8aFEF2YXRhclBhdGhE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXRhLnByb3RvIl8KCkF2YXRhclN5bmMSHAoLYXZhdGFyX2xpc3QYBiADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "By5BdmF0YXISMwoaYXZhdGFyX3BhdGhfZGF0YV9pbmZvX2xpc3QYDiADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Dy5BdmF0YXJQYXRoRGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			AvatarReflection.Descriptor,
			AvatarPathDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarSync), AvatarSync.Parser, new string[2] { "AvatarList", "AvatarPathDataInfoList" }, null, null, null, null)
		}));
	}
}
