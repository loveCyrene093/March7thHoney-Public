using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarPathChangedNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarPathChangedNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1BdmF0YXJQYXRoQ2hhbmdlZE5vdGlmeS5wcm90bxoZTXVsdGlQYXRoQXZh";
		buffer[1] = "dGFyVHlwZS5wcm90byJrChdBdmF0YXJQYXRoQ2hhbmdlZE5vdGlmeRIWCg5i";
		buffer[2] = "YXNlX2F2YXRhcl9pZBgFIAEoDRI4ChpjdXJfbXVsdGlfcGF0aF9hdmF0YXJf";
		buffer[3] = "dHlwZRgHIAEoDjIULk11bHRpUGF0aEF2YXRhclR5cGVCFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MultiPathAvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarPathChangedNotify), AvatarPathChangedNotify.Parser, new string[2] { "BaseAvatarId", "CurMultiPathAvatarType" }, null, null, null, null)
		}));
	}
}
