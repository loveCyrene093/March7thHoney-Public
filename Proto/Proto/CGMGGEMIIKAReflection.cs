using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CGMGGEMIIKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CGMGGEMIIKAReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFDR01HR0VNSUlLQS5wcm90bxoRTVBHSU9IRE1GQ0cucHJvdG8aEVBCS1BQ";
		buffer[1] = "RUFQQk9NLnByb3RvIpMBCgtDR01HR0VNSUlLQRITCgtPS0NOSFBMT01DRBgB";
		buffer[2] = "IAEoDRIbCgVzdGF0ZRgHIAEoDjIMLlBCS1BQRUFQQk9NEgoKAmhwGAogASgN";
		buffer[3] = "Eh8KCWl0ZW1fbGlzdBgLIAMoCzIMLk1QR0lPSERNRkNHEhAKCHNjb3JlX2lk";
		buffer[4] = "GA4gASgNEhMKC01DQ0xORENKQU1JGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[5] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MPGIOHDMFCGReflection.Descriptor,
			PBKPPEAPBOMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CGMGGEMIIKA), CGMGGEMIIKA.Parser, new string[6] { "OKCNHPLOMCD", "State", "Hp", "ItemList", "ScoreId", "MCCLNDCJAMI" }, null, null, null, null)
		}));
	}
}
