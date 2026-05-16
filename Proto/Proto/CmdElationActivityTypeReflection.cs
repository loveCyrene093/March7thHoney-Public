using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdElationActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdElationActivityTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChxDbWRFbGF0aW9uQWN0aXZpdHlUeXBlLnByb3RvKvkBChZDbWRFbGF0aW9u";
		buffer[1] = "QWN0aXZpdHlUeXBlEhsKF0xNQUxCT0FQS09IX1BDUERIRUxQS0VNEAASKAoj";
		buffer[2] = "Q21kRWxhdGlvbkFjdGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkQkUcSJgohQ21k";
		buffer[3] = "RW50ZXJFbGF0aW9uQWN0aXZpdHlTdGFnZVNjUnNwEJNHEiYKIUNtZEVudGVy";
		buffer[4] = "RWxhdGlvbkFjdGl2aXR5U3RhZ2VDc1JlcRCNRxIjCh5DbWRHZXRFbGF0aW9u";
		buffer[5] = "QWN0aXZpdHlEYXRhU2NSc3AQlkcSIwoeQ21kR2V0QWN0aXZpdHlFbGF0aW9u";
		buffer[6] = "RGF0YUNzUmVxEJVHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdElationActivityType) }, null, null));
	}
}
