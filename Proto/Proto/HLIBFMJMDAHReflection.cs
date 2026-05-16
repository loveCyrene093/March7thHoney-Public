using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLIBFMJMDAHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLIBFMJMDAHReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFITElCRk1KTURBSC5wcm90bxoRQ05QT0hDR1BERlAucHJvdG8aEUdLREVL";
		buffer[1] = "SktPSUpOLnByb3RvGhFMS05PRkpIR0dBRC5wcm90byKLAQoLSExJQkZNSk1E";
		buffer[2] = "QUgSEwoLSkFER09KTEVLS0sYAiADKA0SIQoLTk9ETE5LTU1CSUoYBCADKAsy";
		buffer[3] = "DC5HS0RFS0pLT0lKThIhCgtLR0FPSEJCR1BERhgJIAMoCzIMLkxLTk9GSkhH";
		buffer[4] = "R0FEEiEKC05NTk9DSkRKS09HGA4gASgLMgwuQ05QT0hDR1BERlBCFqoCE01h";
		buffer[5] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			CNPOHCGPDFPReflection.Descriptor,
			GKDEKJKOIJNReflection.Descriptor,
			LKNOFJHGGADReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLIBFMJMDAH), HLIBFMJMDAH.Parser, new string[4] { "JADGOJLEKKK", "NODLNKMMBIJ", "KGAOHBBGPDF", "NMNOCJDJKOG" }, null, null, null, null)
		}));
	}
}
