using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KDBLKOGKHEEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KDBLKOGKHEEReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFLREJMS09HS0hFRS5wcm90bxoRREdDR0ZGTEtLQUEucHJvdG8aIVN3b3Jk";
		buffer[1] = "VHJhaW5pbmdEYWlseVBoYXNlVHlwZS5wcm90byJ4CgtLREJMS09HS0hFRRIx";
		buffer[2] = "CgtESUNDRUlBRklKQhgCIAEoDjIcLlN3b3JkVHJhaW5pbmdEYWlseVBoYXNl";
		buffer[3] = "VHlwZRITCgtFREtKUEJCRENCRxgEIAMoDRIhCgtQSUdFT0ZCQ05DThgJIAMo";
		buffer[4] = "CzIMLkRHQ0dGRkxLS0FBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[5] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DGCGFFLKKAAReflection.Descriptor,
			SwordTrainingDailyPhaseTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KDBLKOGKHEE), KDBLKOGKHEE.Parser, new string[3] { "DICCEIAFIJB", "EDKJPBBDCBG", "PIGEOFBCNCN" }, null, null, null, null)
		}));
	}
}
