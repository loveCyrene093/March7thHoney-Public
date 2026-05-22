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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFQTUJJSEpMQUlQTC5wcm90bxoRSlBGSUVMRkVGSEQucHJvdG8ihAEKC1BN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QklISkxBSVBMEhMKC05KQUNNTU5QQ0JKGAQgAygNEhMKC0tCQlBOS0dHQ1BO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "GAcgAygNEhMKC0xQSklKSEdQR0hNGAggASgNEhMKC09QSFBNS0ZHTEJBGAkg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ASgNEiEKC0JHREdHQUxBT0RPGAsgASgLMgwuSlBGSUVMRkVGSERCFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { JPFIELFEFHDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMBIHJLAIPL), PMBIHJLAIPL.Parser, new string[5] { "NJACMMNPCBJ", "KBBPNKGGCPN", "LPJIJHGPGHM", "OPHPMKFGLBA", "BGDGGALAODO" }, null, null, null, null)
		}));
	}
}
