using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartFightFestCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartFightFestCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChlTdGFydEZpZ2h0RmVzdENzUmVxLnByb3RvGhFCTEtHREdBUEJLQy5wcm90";
		buffer[1] = "bxoTRmlnaHRGZXN0VHlwZS5wcm90byKJAQoTU3RhcnRGaWdodEZlc3RDc1Jl";
		buffer[2] = "cRIhCgthdmF0YXJfbGlzdBgDIAMoCzIMLkJMS0dER0FQQktDEgoKAmlkGAQg";
		buffer[3] = "ASgNEhwKBHR5cGUYBSABKA4yDi5GaWdodEZlc3RUeXBlEhAKCGV2ZW50X2lk";
		buffer[4] = "GAggASgNEhMKC0dJR1BISkVCREZMGAogAygNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[5] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BLKGDGAPBKCReflection.Descriptor,
			FightFestTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartFightFestCsReq), StartFightFestCsReq.Parser, new string[5] { "AvatarList", "Id", "Type", "EventId", "GIGPHJEBDFL" }, null, null, null, null)
		}));
	}
}
