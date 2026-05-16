using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ContentPackageStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ContentPackageStatusReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChpDb250ZW50UGFja2FnZVN0YXR1cy5wcm90byq5AQoUQ29udGVudFBhY2th";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Z2VTdGF0dXMSHQoZQ29udGVudFBhY2thZ2VTdGF0dXNfTm9uZRAAEh0KGUNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bnRlbnRQYWNrYWdlU3RhdHVzX0luaXQQARIeChpDb250ZW50UGFja2FnZVN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "YXR1c19Eb2luZxACEiEKHUNvbnRlbnRQYWNrYWdlU3RhdHVzX0ZpbmlzaGVk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EAMSIAocQ29udGVudFBhY2thZ2VTdGF0dXNfUmVsZWFzZRAEQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ContentPackageStatus) }, null, null));
	}
}
