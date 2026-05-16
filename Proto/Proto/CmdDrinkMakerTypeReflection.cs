using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdDrinkMakerTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdDrinkMakerTypeReflection()
	{
		_003C_003Ey__InlineArray17<string> buffer = default(_003C_003Ey__InlineArray17<string>);
		buffer[0] = "ChdDbWREcmlua01ha2VyVHlwZS5wcm90byqpBQoRQ21kRHJpbmtNYWtlclR5";
		buffer[1] = "cGUSGwoXR0VCTEVDTUZHR0FfUENQREhFTFBLRU0QABIjCh5DbWRHZXREcmlu";
		buffer[2] = "a01ha2VyRGF5RW5kU2NOb3RpZnkQyzYSFgoRQ21kTWFrZURyaW5rU2NSc3AQ";
		buffer[3] = "zjYSHQoYQ21kTWFrZU1pc3Npb25Ecmlua0NzUmVxENI2EiQKH0NtZERyaW5r";
		buffer[4] = "TWFrZXJDaGVlcnNHZXREYXRhU2NSc3AQxzYSHgoZQ21kR2V0RHJpbmtNYWtl";
		buffer[5] = "ckRhdGFTY1JzcBDYNhImCiFDbWREcmlua01ha2VyQ2hlZXJzTWFrZURyaW5r";
		buffer[6] = "U2NSc3AQ0TYSIAobQ21kRHJpbmtNYWtlckNoYWxsZW5nZUNzUmVxENc2Eh4K";
		buffer[7] = "GUNtZEdldERyaW5rTWFrZXJEYXRhQ3NSZXEQxTYSHQoYQ21kTWFrZU1pc3Np";
		buffer[8] = "b25Ecmlua1NjUnNwENU2EisKJkNtZERyaW5rTWFrZXJDaGVlcnNFbnRlck5l";
		buffer[9] = "eHRHcm91cFNjUnNwENA2EiIKHUNtZEVuZERyaW5rTWFrZXJTZXF1ZW5jZUNz";
		buffer[10] = "UmVxENM2EiAKG0NtZERyaW5rTWFrZXJDaGFsbGVuZ2VTY1JzcBDPNhIWChFD";
		buffer[11] = "bWRNYWtlRHJpbmtDc1JlcRDGNhImCiFDbWREcmlua01ha2VyQ2hlZXJzTWFr";
		buffer[12] = "ZURyaW5rQ3NSZXEQzTYSIgodQ21kRHJpbmtNYWtlclVwZGF0ZVRpcHNOb3Rp";
		buffer[13] = "ZnkQ1jYSIgodQ21kRW5kRHJpbmtNYWtlclNlcXVlbmNlU2NSc3AQzDYSJAof";
		buffer[14] = "Q21kRHJpbmtNYWtlckNoZWVyc0dldERhdGFDc1JlcRDINhIrCiZDbWREcmlu";
		buffer[15] = "a01ha2VyQ2hlZXJzRW50ZXJOZXh0R3JvdXBDc1JlcRDJNkIWqgITTWFyY2g3";
		buffer[16] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdDrinkMakerType) }, null, null));
	}
}
