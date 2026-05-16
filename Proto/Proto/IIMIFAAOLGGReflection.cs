using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IIMIFAAOLGGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IIMIFAAOLGGReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFJSU1JRkFBT0xHRy5wcm90bxoRQkFEQ0dCUEVBTkkucHJvdG8aEUJHS0lO";
		buffer[1] = "Q0ZHS0dJLnByb3RvGhFCTEFET05JTEtITy5wcm90bxoRRVBQR1BIS0xITkYu";
		buffer[2] = "cHJvdG8aEU5DRENLSEhQRERFLnByb3RvIrwBCgtJSU1JRkFBT0xHRxIhCgtI";
		buffer[3] = "Q0VIT0hEQ0NGRRgBIAEoCzIMLkVQUEdQSEtMSE5GEiEKC0FIQkZBQU1OS05P";
		buffer[4] = "GAggASgLMgwuQkdLSU5DRkdLR0kSIQoLTEhOQ0dES0ZBR00YCSABKAsyDC5O";
		buffer[5] = "Q0RDS0hIUERERRIhCgtJQ0pGTExEQ0ZITRgMIAEoCzIMLkJBRENHQlBFQU5J";
		buffer[6] = "EiEKC0lNUEJFTEpHREpIGA8gASgLMgwuQkxBRE9OSUxLSE9CFqoCE01hcmNo";
		buffer[7] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			BADCGBPEANIReflection.Descriptor,
			BGKINCFGKGIReflection.Descriptor,
			BLADONILKHOReflection.Descriptor,
			EPPGPHKLHNFReflection.Descriptor,
			NCDCKHHPDDEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IIMIFAAOLGG), IIMIFAAOLGG.Parser, new string[5] { "HCEHOHDCCFE", "AHBFAAMNKNO", "LHNCGDKFAGM", "ICJFLLDCFHM", "IMPBELJGDJH" }, null, null, null, null)
		}));
	}
}
