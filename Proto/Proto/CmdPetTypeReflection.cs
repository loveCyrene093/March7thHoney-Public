using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPetTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPetTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChBDbWRQZXRUeXBlLnByb3RvKtABCgpDbWRQZXRUeXBlEhsKF0FNUExOQkJJ";
		buffer[1] = "QkpIX1BDUERIRUxQS0VNEAASFgoRQ21kUmVjYWxsUGV0U2NSc3AQuDsSFwoS";
		buffer[2] = "Q21kR2V0UGV0RGF0YVNjUnNwELQ7EhYKEUNtZFN1bW1vblBldENzUmVxELI7";
		buffer[3] = "EhcKEkNtZEdldFBldERhdGFDc1JlcRCxOxIWChFDbWRTdW1tb25QZXRTY1Jz";
		buffer[4] = "cBC+OxITCg5DbWRGTE5NQ01OSkdITxC6OxIWChFDbWRSZWNhbGxQZXRDc1Jl";
		buffer[5] = "cRCzO0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPetType) }, null, null));
	}
}
