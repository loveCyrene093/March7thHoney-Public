using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSceneReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSceneReasonReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChZFbnRlclNjZW5lUmVhc29uLnByb3RvKtABChBFbnRlclNjZW5lUmVhc29u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "EhsKF0VOVEVSX1NDRU5FX1JFQVNPTl9OT05FEAASKAokRU5URVJfU0NFTkVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "UkVBU09OX0NIQUxMRU5HRV9USU1FT1VUEAESJAogRU5URVJfU0NFTkVfUkVB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "U09OX1JPR1VFX1RJTUVPVVQQAhInCiNFTlRFUl9TQ0VORV9SRUFTT05fQ0hB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "TkdFX1NUT1JZTElORRADEiYKIkVOVEVSX1NDRU5FX1JFQVNPTl9ESU1FTlNJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "T05fTUVSR0UQBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(EnterSceneReason) }, null, null));
	}
}
