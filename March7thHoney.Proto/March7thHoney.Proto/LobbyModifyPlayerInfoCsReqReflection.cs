using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyModifyPlayerInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyModifyPlayerInfoCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiBMb2JieU1vZGlmeVBsYXllckluZm9Dc1JlcS5wcm90bxoWTG9iYnlHYW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RXh0SW5mby5wcm90bxoVTG9iYnlNb2RpZnlUeXBlLnByb3RvInkKGkxvYmJ5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "TW9kaWZ5UGxheWVySW5mb0NzUmVxEiYKC0pIQ0pNS0RETk5GGAYgASgLMhEu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "TG9iYnlHYW1lRXh0SW5mbxIeCgR0eXBlGAogASgOMhAuTG9iYnlNb2RpZnlU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "eXBlEhMKC0dDSUlCSEhNUE5QGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			LobbyGameExtInfoReflection.Descriptor,
			LobbyModifyTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyModifyPlayerInfoCsReq), LobbyModifyPlayerInfoCsReq.Parser, new string[3] { "JHCJMKDDNNF", "Type", "GCIIBHHMPNP" }, null, null, null, null)
		}));
	}
}
