using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMatchTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMatchTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChJDbWRNYXRjaFR5cGUucHJvdG8q0wEKDENtZE1hdGNoVHlwZRIbChdQQ0dG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TFBDTkNMTV9QQ1BESEVMUEtFTRAAEhkKFENtZEdldENyb3NzSW5mb0NzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "EKo5EhgKE0NtZENhbmNlbE1hdGNoQ3NSZXEQojkSFwoSQ21kU3RhcnRNYXRj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "aENzUmVxEJE5EhMKDkNtZEFBSENNTUtNRU5BEIs5EhMKDkNtZEpPTERKQktN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "SEdBEJ85EhkKFENtZEdldENyb3NzSW5mb1NjUnNwEIk5EhMKDkNtZEpPRVBK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "SktJUEpDEKc5QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMatchType) }, null, null));
	}
}
