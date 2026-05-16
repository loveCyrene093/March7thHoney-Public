using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyAreaReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyAreaReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChRUcmFpblBhcnR5QXJlYS5wcm90bxoVQXJlYUR5bmFtaWNJbmZvLnByb3Rv";
		buffer[1] = "GhJBcmVhU3RlcEluZm8ucHJvdG8i0gEKDlRyYWluUGFydHlBcmVhEhQKDHN0";
		buffer[2] = "ZXBfaWRfbGlzdBgHIAMoDRImCgxkeW5hbWljX2luZm8YCCADKAsyEC5BcmVh";
		buffer[3] = "RHluYW1pY0luZm8SJQoOYXJlYV9zdGVwX2luZm8YCiABKAsyDS5BcmVhU3Rl";
		buffer[4] = "cEluZm8SDwoHYXJlYV9pZBgLIAEoDRIbChNzdGF0aWNfcHJvcF9pZF9saXN0";
		buffer[5] = "GAwgAygNEhsKE3ZlcmlmeV9zdGVwX2lkX2xpc3QYDSADKA0SEAoIcHJvZ3Jl";
		buffer[6] = "c3MYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AreaDynamicInfoReflection.Descriptor,
			AreaStepInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyArea), TrainPartyArea.Parser, new string[7] { "StepIdList", "DynamicInfo", "AreaStepInfo", "AreaId", "StaticPropIdList", "VerifyStepIdList", "Progress" }, null, null, null, null)
		}));
	}
}
