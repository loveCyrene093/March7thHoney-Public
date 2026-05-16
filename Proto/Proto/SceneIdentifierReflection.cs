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
		buffer[0] = "ChVTY2VuZUlkZW50aWZpZXIucHJvdG8aElRlbGVwb3J0SW5mby5wcm90byJ6";
		buffer[1] = "Cg9TY2VuZUlkZW50aWZpZXISEAoIZmxvb3JfaWQYAiABKA0SGgoSZ2FtZV9z";
		buffer[2] = "dG9yeV9saW5lX2lkGAYgASgNEhIKCmNvbnRlbnRfaWQYDiABKA0SJQoNdGVs";
		buffer[3] = "ZXBvcnRfaW5mbxjVDCABKAsyDS5UZWxlcG9ydEluZm9CFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { TeleportInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneIdentifier), SceneIdentifier.Parser, new string[4] { "FloorId", "GameStoryLineId", "ContentId", "TeleportInfo" }, null, null, null, null)
		}));
	}
}
