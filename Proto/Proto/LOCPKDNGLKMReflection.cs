using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LOCPKDNGLKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LOCPKDNGLKMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMT0NQS0ROR0xLTS5wcm90byKpAQoLTE9DUEtETkdMS00SDAoEd2F2ZRgB";
		buffer[1] = "IAEoDRITCgtCUE1DR0tLSkdQRhgCIAEoARITCgtCTkZDQUFQQUJDRhgDIAEo";
		buffer[2] = "ARITCgtGSE9MQkpHT1BHSRgEIAEoDRITCgtETEhMUE5MSUJBRhgFIAEoDRIO";
		buffer[3] = "CgZzdGF0dXMYBiABKA0SEwoLT0RJQUNMSUtJRlAYByABKA0SEwoLRkxNRkhE";
		buffer[4] = "SEZJT0oYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LOCPKDNGLKM), LOCPKDNGLKM.Parser, new string[8] { "Wave", "BPMCGKKJGPF", "BNFCAAPABCF", "FHOLBJGOPGI", "DLHLPNLIBAF", "Status", "ODIACLIKIFP", "FLMFHDHFIOJ" }, null, null, null, null)
		}));
	}
}
