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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChRDbWRQYXJrb3VyVHlwZS5wcm90byqrAgoOQ21kUGFya291clR5cGUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "UENIRU9BSUJFS0tfUENQREhFTFBLRU0QABIiCh1DbWRQYXJrb3VyR2V0UmFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "a2luZ0luZm9Dc1JlcRC+QRIbChZDbWRQYXJrb3VyR2V0RGF0YVNjUnNwENBB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "Eh4KGUNtZFBhcmtvdXJTdGFydExldmVsU2NSc3AQxEESHAoXQ21kUGFya291";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "ckVuZExldmVsU2NSc3AQzUESGwoWQ21kUGFya291ckdldERhdGFDc1JlcRC9";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "QRIeChlDbWRQYXJrb3VyU3RhcnRMZXZlbENzUmVxEMtBEhwKF0NtZFBhcmtv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "dXJFbmRMZXZlbENzUmVxEMpBEiIKHUNtZFBhcmtvdXJHZXRSYW5raW5nSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "b1NjUnNwEMZBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdParkourType) }, null, null));
	}
}
