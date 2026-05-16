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
		buffer[0] = "ChFNQ1BQSUVKRUJFRi5wcm90bxoRQkhGT05FRkdHQUcucHJvdG8aEU5LTEFG";
		buffer[1] = "RkxKQ0hHLnByb3RvImgKC01DUFBJRUpFQkVGEiEKC0xFS0dCTUNPSkRCGAEg";
		buffer[2] = "ASgLMgwuTktMQUZGTEpDSEcSIQoLS0JIUElQRktQQUMYAiADKAsyDC5CSEZP";
		buffer[3] = "TkVGR0dBRxITCgtIQUpQS0pPQ0JDTBgDIAEoCEIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BHFONEFGGAGReflection.Descriptor,
			NKLAFFLJCHGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MCPPIEJEBEF), MCPPIEJEBEF.Parser, new string[3] { "LEKGBMCOJDB", "KBHPIPFKPAC", "HAJPKJOCBCL" }, null, null, null, null)
		}));
	}
}
