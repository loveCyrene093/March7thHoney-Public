using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GameplayCounterUpdateReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GameplayCounterUpdateReasonReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiFHYW1lcGxheUNvdW50ZXJVcGRhdGVSZWFzb24ucHJvdG8qzQEKG0dhbWVw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "bGF5Q291bnRlclVwZGF0ZVJlYXNvbhInCiNHQU1FUExBWV9DT1VOVEVSX1VQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "REFURV9SRUFTT05fTk9ORRAAEisKJ0dBTUVQTEFZX0NPVU5URVJfVVBEQVRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "X1JFQVNPTl9BQ1RJVkFURRABEi0KKUdBTUVQTEFZX0NPVU5URVJfVVBEQVRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "X1JFQVNPTl9ERUFDVElWQVRFEAISKQolR0FNRVBMQVlfQ09VTlRFUl9VUERB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "VEVfUkVBU09OX0NIQU5HRRADQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GameplayCounterUpdateReason) }, null, null));
	}
}
