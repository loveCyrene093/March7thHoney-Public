using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KFOEEPGNDOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KFOEEPGNDOCReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFLRk9FRVBHTkRPQy5wcm90byrYAQoLS0ZPRUVQR05ET0MSGwoXS0ZPRUVQ";
		buffer[1] = "R05ET0NfUENQREhFTFBLRU0QABIbChdLRk9FRVBHTkRPQ19OQUpDUE9QSkdM";
		buffer[2] = "QhACEhsKF0tGT0VFUEdORE9DX09DS0VKTUZNTkFBEAMSGwoXS0ZPRUVQR05E";
		buffer[3] = "T0NfTFBLTU5HUElBSlAQBBIbChdLRk9FRVBHTkRPQ19GTVBOTkhER0hFTRAF";
		buffer[4] = "EhsKF0tGT0VFUEdORE9DX0JLQUJLTEFQRUhMEAYSGwoXS0ZPRUVQR05ET0Nf";
		buffer[5] = "Q0JIRUpQUE5OTkoQB0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(KFOEEPGNDOC) }, null, null));
	}
}
