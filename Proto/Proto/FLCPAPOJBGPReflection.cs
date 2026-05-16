using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FLCPAPOJBGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FLCPAPOJBGPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGTENQQVBPSkJHUC5wcm90byqBAQoLRkxDUEFQT0pCR1ASGwoXRkxDUEFQ";
		buffer[1] = "T0pCR1BfUENQREhFTFBLRU0QABIbChdGTENQQVBPSkJHUF9QQ1BLRkNET0pQ";
		buffer[2] = "RBABEhsKF0ZMQ1BBUE9KQkdQX0hQSkVCRkZISk5QEAISGwoXRkxDUEFQT0pC";
		buffer[3] = "R1BfS0xIRENPUFBMTkcQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FLCPAPOJBGP) }, null, null));
	}
}
