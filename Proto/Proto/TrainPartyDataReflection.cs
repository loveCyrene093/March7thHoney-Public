using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyDataReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChRUcmFpblBhcnR5RGF0YS5wcm90bxoRRktQTU9LT0pOSFAucHJvdG8aFFRy";
		buffer[1] = "YWluUGFydHlJbmZvLnByb3RvGh1UcmFpblBhcnR5UGFzc2VuZ2VySW5mby5w";
		buffer[2] = "cm90byLmAQoOVHJhaW5QYXJ0eURhdGESIQoLR0dIT0FJRE1PTUMYAiABKAsy";
		buffer[3] = "DC5GS1BNT0tPSk5IUBIRCglyZWNvcmRfaWQYBCABKA0SMAoOcGFzc2VuZ2Vy";
		buffer[4] = "X2luZm8YBSABKAsyGC5UcmFpblBhcnR5UGFzc2VuZ2VySW5mbxIpChB0cmFp";
		buffer[5] = "bl9wYXJ0eV9pbmZvGAogASgLMg8uVHJhaW5QYXJ0eUluZm8SEwoLSFBIT01Q";
		buffer[6] = "SkVEQkgYCyABKAgSEwoLS1BDSEVLRERGTUcYDCABKA0SFwoPdW5sb2NrX2Fy";
		buffer[7] = "ZWFfbnVtGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			FKPMOKOJNHPReflection.Descriptor,
			TrainPartyInfoReflection.Descriptor,
			TrainPartyPassengerInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyData), TrainPartyData.Parser, new string[7] { "GGHOAIDMOMC", "RecordId", "PassengerInfo", "TrainPartyInfo", "HPHOMPJEDBH", "KPCHEKDDFMG", "UnlockAreaNum" }, null, null, null, null)
		}));
	}
}
