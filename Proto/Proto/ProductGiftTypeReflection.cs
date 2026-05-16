using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ProductGiftTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ProductGiftTypeReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		buffer[0] = "ChVQcm9kdWN0R2lmdFR5cGUucHJvdG8qnwYKD1Byb2R1Y3RHaWZ0VHlwZRIV";
		buffer[1] = "ChFQUk9EVUNUX0dJRlRfTk9ORRAAEhUKEVBST0RVQ1RfR0lGVF9DT0lOEAES";
		buffer[2] = "GwoXUFJPRFVDVF9HSUZUX01PTlRIX0NBUkQQAhIWChJQUk9EVUNUX0dJRlRf";
		buffer[3] = "QlBfNjgQAxIXChNQUk9EVUNUX0dJRlRfQlBfMTI4EAQSIQodUFJPRFVDVF9H";
		buffer[4] = "SUZUX0JQNjhfVVBHUkFERV8xMjgQBRIbChdQUk9EVUNUX0dJRlRfUE9JTlRf";
		buffer[5] = "Q0FSRBAGEh8KG1BST0RVQ1RfR0lGVF9QU19QUkVfT1JERVJfMRAHEh8KG1BS";
		buffer[6] = "T0RVQ1RfR0lGVF9QU19QUkVfT1JERVJfMhAIEiIKHlBST0RVQ1RfR0lGVF9H";
		buffer[7] = "T09HTEVfUE9JTlRTXzEwMBAJEiIKHlBST0RVQ1RfR0lGVF9HT09HTEVfUE9J";
		buffer[8] = "TlRTXzE1MBAKEiIKHlBST0RVQ1RfR0lGVF9QU19QT0lOVF9DQVJEXzAzMBAL";
		buffer[9] = "EiIKHlBST0RVQ1RfR0lGVF9QU19QT0lOVF9DQVJEXzA1MBAMEiIKHlBST0RV";
		buffer[10] = "Q1RfR0lGVF9QU19QT0lOVF9DQVJEXzEwMBANEhkKFVBST0RVQ1RfR0lGVF9Q";
		buffer[11] = "U05fUExVUxAOEhkKFVBST0RVQ1RfR0lGVF9TSU5HTEVfNhAPEh8KG1BST0RV";
		buffer[12] = "Q1RfR0lGVF9EQUlMWV9MT0dJTl8zMBAQEiAKHFBST0RVQ1RfR0lGVF9BUFBM";
		buffer[13] = "RV9HSUZUX0NBUkQQERImCiJQUk9EVUNUX0dJRlRfRlRDX1VQX0dBQ0hBX1RJ";
		buffer[14] = "Q0tFVF8xEBISJwojUFJPRFVDVF9HSUZUX0ZUQ19VUF9HQUNIQV9USUNLRVRf";
		buffer[15] = "MTAQExIqCiZQUk9EVUNUX0dJRlRfRlRDX05PUk1BTF9HQUNIQV9USUNLRVRf";
		buffer[16] = "MRAUEisKJ1BST0RVQ1RfR0lGVF9GVENfTk9STUFMX0dBQ0hBX1RJQ0tFVF8x";
		buffer[17] = "MBAVEhoKFlBST0RVQ1RfR0lGVF9USUNLRVRfMTAQFhIbChdFSkVCSElJS0FK";
		buffer[18] = "Rl9EQklBRE5HTkZNRBAXQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[19] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ProductGiftType) }, null, null));
	}
}
