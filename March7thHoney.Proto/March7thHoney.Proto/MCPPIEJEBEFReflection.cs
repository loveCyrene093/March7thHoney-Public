using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MCPPIEJEBEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MCPPIEJEBEFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNQ1BQSUVKRUJFRi5wcm90bxoRQkhGT05FRkdHQUcucHJvdG8aEU5LTEFG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RkxKQ0hHLnByb3RvImgKC01DUFBJRUpFQkVGEiEKC0xFS0dCTUNPSkRCGAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgLMgwuTktMQUZGTEpDSEcSIQoLS0JIUElQRktQQUMYAiADKAsyDC5CSEZP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TkVGR0dBRxITCgtIQUpQS0pPQ0JDTBgDIAEoCEIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			BHFONEFGGAGReflection.Descriptor,
			NKLAFFLJCHGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MCPPIEJEBEF), MCPPIEJEBEF.Parser, new string[3] { "LEKGBMCOJDB", "KBHPIPFKPAC", "HAJPKJOCBCL" }, null, null, null, null)
		}));
	}
}
