using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueEndlessTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueEndlessTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChlDbWRSb2d1ZUVuZGxlc3NUeXBlLnByb3RvKt0DChNDbWRSb2d1ZUVuZGxl";
		buffer[1] = "c3NUeXBlEhsKF0dCSUVJSEFBRkZJX0lFTUlHSklLRUlKEAASLQooQ21kUm9n";
		buffer[2] = "dWVFbmRsZXNzQWN0aXZpdHlCYXR0bGVFbmRTY05vdGlmeRD1LhIwCitDbWRU";
		buffer[3] = "YWtlUm9ndWVFbmRsZXNzQWN0aXZpdHlQb2ludFJld2FyZFNjUnNwEPIuEisK";
		buffer[4] = "JkNtZEVudGVyUm9ndWVFbmRsZXNzQWN0aXZpdHlTdGFnZVNjUnNwEPcuEigK";
		buffer[5] = "I0NtZEdldFJvZ3VlRW5kbGVzc0FjdGl2aXR5RGF0YUNzUmVxEPkuEigKI0Nt";
		buffer[6] = "ZEdldFJvZ3VlRW5kbGVzc0FjdGl2aXR5RGF0YVNjUnNwEPouEjMKLkNtZFRh";
		buffer[7] = "a2VSb2d1ZUVuZGxlc3NBY3Rpdml0eUFsbEJvbnVzUmV3YXJkQ3NSZXEQ9i4S";
		buffer[8] = "MAorQ21kVGFrZVJvZ3VlRW5kbGVzc0FjdGl2aXR5UG9pbnRSZXdhcmRDc1Jl";
		buffer[9] = "cRD0LhIzCi5DbWRUYWtlUm9ndWVFbmRsZXNzQWN0aXZpdHlBbGxCb251c1Jl";
		buffer[10] = "d2FyZFNjUnNwEPMuEisKJkNtZEVudGVyUm9ndWVFbmRsZXNzQWN0aXZpdHlT";
		buffer[11] = "dGFnZUNzUmVxEPEuQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueEndlessType) }, null, null));
	}
}
