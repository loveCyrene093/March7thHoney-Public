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
		buffer[0] = "CiFHYW1lcGxheUNvdW50ZXJVcGRhdGVSZWFzb24ucHJvdG8qzQEKG0dhbWVw";
		buffer[1] = "bGF5Q291bnRlclVwZGF0ZVJlYXNvbhInCiNHQU1FUExBWV9DT1VOVEVSX1VQ";
		buffer[2] = "REFURV9SRUFTT05fTk9ORRAAEisKJ0dBTUVQTEFZX0NPVU5URVJfVVBEQVRF";
		buffer[3] = "X1JFQVNPTl9BQ1RJVkFURRABEi0KKUdBTUVQTEFZX0NPVU5URVJfVVBEQVRF";
		buffer[4] = "X1JFQVNPTl9ERUFDVElWQVRFEAISKQolR0FNRVBMQVlfQ09VTlRFUl9VUERB";
		buffer[5] = "VEVfUkVBU09OX0NIQU5HRRADQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[6] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GameplayCounterUpdateReason) }, null, null));
	}
}
