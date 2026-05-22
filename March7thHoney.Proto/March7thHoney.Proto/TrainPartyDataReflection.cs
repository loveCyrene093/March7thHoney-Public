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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChRUcmFpblBhcnR5RGF0YS5wcm90bxoRRktQTU9LT0pOSFAucHJvdG8aFFRy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "YWluUGFydHlJbmZvLnByb3RvGh1UcmFpblBhcnR5UGFzc2VuZ2VySW5mby5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "cm90byLmAQoOVHJhaW5QYXJ0eURhdGESIQoLR0dIT0FJRE1PTUMYAiABKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "DC5GS1BNT0tPSk5IUBIRCglyZWNvcmRfaWQYBCABKA0SMAoOcGFzc2VuZ2Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "X2luZm8YBSABKAsyGC5UcmFpblBhcnR5UGFzc2VuZ2VySW5mbxIpChB0cmFp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "bl9wYXJ0eV9pbmZvGAogASgLMg8uVHJhaW5QYXJ0eUluZm8SEwoLSFBIT01Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "SkVEQkgYCyABKAgSEwoLS1BDSEVLRERGTUcYDCABKA0SFwoPdW5sb2NrX2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "ZWFfbnVtGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
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
