using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerLoginScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerLoginScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChZQbGF5ZXJMb2dpblNjUnNwLnByb3RvGhVQbGF5ZXJCYXNpY0luZm8ucHJv";
		buffer[1] = "dG8i9wEKEFBsYXllckxvZ2luU2NSc3ASJAoKYmFzaWNfaW5mbxgBIAEoCzIQ";
		buffer[2] = "LlBsYXllckJhc2ljSW5mbxIUCgxsb2dpbl9yYW5kb20YBCABKAQSDwoHc3Rh";
		buffer[3] = "bWluYRgHIAEoDRIbChNzZXJ2ZXJfdGltZXN0YW1wX21zGAggASgEEg8KB3Jl";
		buffer[4] = "dGNvZGUYCSABKA0SEwoLUEpOS0VFT0tHQk8YCiABKAkSFAoMY3VyX3RpbWV6";
		buffer[5] = "b25lGAsgASgFEhMKC0lDSExKRExFUE5MGAwgASgJEhMKC0NJR05FSktES0pG";
		buffer[6] = "GA0gASgIEhMKC0FMTEhEQUZHRENKGA4gASgIQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[7] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PlayerBasicInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerLoginScRsp), PlayerLoginScRsp.Parser, new string[10] { "BasicInfo", "LoginRandom", "Stamina", "ServerTimestampMs", "Retcode", "PJNKEEOKGBO", "CurTimezone", "ICHLJDLEPNL", "CIGNEJKDKJF", "ALLHDAFGDCJ" }, null, null, null, null)
		}));
	}
}
