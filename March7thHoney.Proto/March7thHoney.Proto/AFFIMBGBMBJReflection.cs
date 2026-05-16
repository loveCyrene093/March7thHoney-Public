using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AFFIMBGBMBJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AFFIMBGBMBJReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFBRkZJTUJHQk1CSi5wcm90bxocTXVzZXVtUmFuZG9tRXZlbnRTdGF0ZS5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "cm90byKwAQoLQUZGSU1CR0JNQkoSJgoFc3RhdGUYASABKA4yFy5NdXNldW1S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "YW5kb21FdmVudFN0YXRlEhMKC0lMSEFCRkpLRUdEGAIgASgNEhMKC0hCRENI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "SU1GS0RLGAMgASgNEhMKC09ESUFDTElLSUZQGAggASgNEhMKC0dGSEtCTUxE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "S0RQGAogASgNEhMKC0RBT0RQR0RERkNBGAsgAygNEhAKCGV2ZW50X2lkGA4g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { MuseumRandomEventStateReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AFFIMBGBMBJ), AFFIMBGBMBJ.Parser, new string[7] { "State", "ILHABFJKEGD", "HBDCHIMFKDK", "ODIACLIKIFP", "GFHKBMLDKDP", "DAODPGDDFCA", "EventId" }, null, null, null, null)
		}));
	}
}
