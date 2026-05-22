using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneIdentifierReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneIdentifierReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChVTY2VuZUlkZW50aWZpZXIucHJvdG8aElRlbGVwb3J0SW5mby5wcm90byJ6";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Cg9TY2VuZUlkZW50aWZpZXISEAoIZmxvb3JfaWQYAiABKA0SGgoSZ2FtZV9z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dG9yeV9saW5lX2lkGAYgASgNEhIKCmNvbnRlbnRfaWQYDiABKA0SJQoNdGVs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZXBvcnRfaW5mbxjVDCABKAsyDS5UZWxlcG9ydEluZm9CFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { TeleportInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneIdentifier), SceneIdentifier.Parser, new string[4] { "FloorId", "GameStoryLineId", "ContentId", "TeleportInfo" }, null, null, null, null)
		}));
	}
}
