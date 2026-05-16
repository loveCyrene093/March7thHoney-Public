using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DNAGPMEBBCKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DNAGPMEBBCKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFETkFHUE1FQkJDSy5wcm90byq7AQoLRE5BR1BNRUJCQ0sSGwoXRE5BR1BN";
		buffer[1] = "RUJCQ0tfTUNESkFNTUNMRE8QABIbChdETkFHUE1FQkJDS19DQUlGSUxQQ0RC";
		buffer[2] = "SBABEhsKF0ROQUdQTUVCQkNLX01HQ0xLSkVLSkFBEAISGwoXRE5BR1BNRUJC";
		buffer[3] = "Q0tfSENKT01DSkdHSEQQAxIbChdETkFHUE1FQkJDS19HTEhER0VPS0NKQhAE";
		buffer[4] = "EhsKF0ROQUdQTUVCQkNLX0VFSUNJQk9DS0VBEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DNAGPMEBBCK) }, null, null));
	}
}
