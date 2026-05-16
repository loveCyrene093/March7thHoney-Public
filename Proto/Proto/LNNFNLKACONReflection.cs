using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LNNFNLKACONReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LNNFNLKACONReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMTk5GTkxLQUNPTi5wcm90byqBAQoLTE5ORk5MS0FDT04SGwoXTE5ORk5M";
		buffer[1] = "S0FDT05fUENQREhFTFBLRU0QABIbChdMTk5GTkxLQUNPTl9OR01NSUNPR0RG";
		buffer[2] = "UBABEhsKF0xOTkZOTEtBQ09OX0tMSERDT1BQTE5HEAISGwoXTE5ORk5MS0FD";
		buffer[3] = "T05fTEpGS1BEQUhLSEYQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LNNFNLKACON) }, null, null));
	}
}
