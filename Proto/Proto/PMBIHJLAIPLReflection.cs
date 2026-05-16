using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PMBIHJLAIPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PMBIHJLAIPLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQTUJJSEpMQUlQTC5wcm90bxoRSlBGSUVMRkVGSEQucHJvdG8ihAEKC1BN";
		buffer[1] = "QklISkxBSVBMEhMKC05KQUNNTU5QQ0JKGAQgAygNEhMKC0tCQlBOS0dHQ1BO";
		buffer[2] = "GAcgAygNEhMKC0xQSklKSEdQR0hNGAggASgNEhMKC09QSFBNS0ZHTEJBGAkg";
		buffer[3] = "ASgNEiEKC0JHREdHQUxBT0RPGAsgASgLMgwuSlBGSUVMRkVGSERCFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JPFIELFEFHDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMBIHJLAIPL), PMBIHJLAIPL.Parser, new string[5] { "NJACMMNPCBJ", "KBBPNKGGCPN", "LPJIJHGPGHM", "OPHPMKFGLBA", "BGDGGALAODO" }, null, null, null, null)
		}));
	}
}
