using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdParkourTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdParkourTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChRDbWRQYXJrb3VyVHlwZS5wcm90byqrAgoOQ21kUGFya291clR5cGUSGwoX";
		buffer[1] = "UENIRU9BSUJFS0tfUENQREhFTFBLRU0QABIiCh1DbWRQYXJrb3VyR2V0UmFu";
		buffer[2] = "a2luZ0luZm9Dc1JlcRC+QRIbChZDbWRQYXJrb3VyR2V0RGF0YVNjUnNwENBB";
		buffer[3] = "Eh4KGUNtZFBhcmtvdXJTdGFydExldmVsU2NSc3AQxEESHAoXQ21kUGFya291";
		buffer[4] = "ckVuZExldmVsU2NSc3AQzUESGwoWQ21kUGFya291ckdldERhdGFDc1JlcRC9";
		buffer[5] = "QRIeChlDbWRQYXJrb3VyU3RhcnRMZXZlbENzUmVxEMtBEhwKF0NtZFBhcmtv";
		buffer[6] = "dXJFbmRMZXZlbENzUmVxEMpBEiIKHUNtZFBhcmtvdXJHZXRSYW5raW5nSW5m";
		buffer[7] = "b1NjUnNwEMZBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdParkourType) }, null, null));
	}
}
