using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRaidTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRaidTypeReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		buffer[0] = "ChFDbWRSYWlkVHlwZS5wcm90byrlBAoLQ21kUmFpZFR5cGUSGwoXQUZPRU1L";
		buffer[1] = "SURNSklfUENQREhFTFBLRU0QABIWChFDbWRMZWF2ZVJhaWRTY1JzcBCzERIb";
		buffer[2] = "ChZDbWREZWxTYXZlUmFpZFNjTm90aWZ5ELcREhgKE0NtZFJhaWRLaWNrQnlT";
		buffer[3] = "ZXJ2ZXIQrRESHAoXQUZPRU1LSURNSklfTUxDS0tPTUdCSkUQvhESGwoWQ21k";
		buffer[4] = "R2V0QWxsU2F2ZVJhaWRTY1JzcBCoERIkCh9DbWRUYWtlQ2hhbGxlbmdlUmFp";
		buffer[5] = "ZFJld2FyZENzUmVxEJkREiUKIENtZFNldENsaWVudFJhaWRUYXJnZXRDb3Vu";
		buffer[6] = "dENzUmVxEKoREhYKEUNtZFN0YXJ0UmFpZENzUmVxEKUREiQKH0NtZFRha2VD";
		buffer[7] = "aGFsbGVuZ2VSYWlkUmV3YXJkU2NSc3AQxxESFgoRQ21kTGVhdmVSYWlkQ3NS";
		buffer[8] = "ZXEQthESFgoRQ21kU3RhcnRSYWlkU2NSc3AQnxESGAoTQ21kR2V0U2F2ZVJh";
		buffer[9] = "aWRTY1JzcBCbERIYChNDbWRHZXRSYWlkSW5mb0NzUmVxEJoREhsKFkNtZENo";
		buffer[10] = "YWxsZW5nZVJhaWROb3RpZnkQqxESEwoOQ21kT0hNRkVDSk5MRUcQnRESGAoT";
		buffer[11] = "Q21kR2V0U2F2ZVJhaWRDc1JlcRC8ERIbChZDbWRHZXRBbGxTYXZlUmFpZENz";
		buffer[12] = "UmVxEMoREhYKEUNtZFJhaWRJbmZvTm90aWZ5ELsREhgKE0NtZEdldFJhaWRJ";
		buffer[13] = "bmZvU2NSc3AQxBESJQogQ21kU2V0Q2xpZW50UmFpZFRhcmdldENvdW50U2NS";
		buffer[14] = "c3AQxRFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRaidType) }, null, null));
	}
}
