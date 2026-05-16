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
		buffer[0] = "ChdGcmllbmRBcHBseVNvdXJjZS5wcm90byreAQoRRnJpZW5kQXBwbHlTb3Vy";
		buffer[1] = "Y2USGwoXUEFCQlBIT0lEQkZfUENQREhFTFBLRU0QABIbChdQQUJCUEhPSURC";
		buffer[2] = "Rl9EREVCQUhCRUtISRABEhsKF1BBQkJQSE9JREJGX1BKRU9PTUJGTk1BEAIS";
		buffer[3] = "GwoXUEFCQlBIT0lEQkZfSUxQS1BCT0tNRU4QAxIbChdQQUJCUEhPSURCRl9P";
		buffer[4] = "QU1ITkVER0VLQRAEEhsKF1BBQkJQSE9JREJGX09HRU5BUERESURCEAUSGwoX";
		buffer[5] = "UEFCQlBIT0lEQkZfTERMTUJJRk5QRVAQBkIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[6] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FriendApplySource) }, null, null));
	}
}
