using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFJEDJAFCJNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFJEDJAFCJNReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFJRkpFREpBRkNKTi5wcm90bxoRRU1DSUNQT0hBQUwucHJvdG8aEUlBRE1F";
		buffer[1] = "T01JSUZJLnByb3RvImYKC0lGSkVESkFGQ0pOEiMKC01OSU9NRk9BTUZIGAsg";
		buffer[2] = "ASgLMgwuSUFETUVPTUlJRklIABIjCgtBUERIR0FMTktFQxgOIAEoCzIMLkVN";
		buffer[3] = "Q0lDUE9IQUFMSABCDQoLT0FJSk9QS1BER0pCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EMCICPOHAALReflection.Descriptor,
			IADMEOMIIFIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IFJEDJAFCJN), IFJEDJAFCJN.Parser, new string[2] { "MNIOMFOAMFH", "APDHGALNKEC" }, new string[1] { "OAIJOPKPDGJ" }, null, null, null)
		}));
	}
}
