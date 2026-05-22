using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendApplySourceReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendApplySourceReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChdGcmllbmRBcHBseVNvdXJjZS5wcm90byreAQoRRnJpZW5kQXBwbHlTb3Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Y2USGwoXUEFCQlBIT0lEQkZfUENQREhFTFBLRU0QABIbChdQQUJCUEhPSURC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "Rl9EREVCQUhCRUtISRABEhsKF1BBQkJQSE9JREJGX1BKRU9PTUJGTk1BEAIS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "GwoXUEFCQlBIT0lEQkZfSUxQS1BCT0tNRU4QAxIbChdQQUJCUEhPSURCRl9P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "QU1ITkVER0VLQRAEEhsKF1BBQkJQSE9JREJGX09HRU5BUERESURCEAUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "UEFCQlBIT0lEQkZfTERMTUJJRk5QRVAQBkIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FriendApplySource) }, null, null));
	}
}
