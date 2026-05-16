using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MKLLLKLEEAPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MKLLLKLEEAPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNS0xMTEtMRUVBUC5wcm90bxoRRUNLSURMSUZBRkcucHJvdG8aEUZLQU5J";
		buffer[1] = "QkRKTktHLnByb3RvIngKC01LTExMS0xFRUFQEhMKC0lKRE1FQ0xKRUJEGAMg";
		buffer[2] = "ASgNEhMKC0RLQUVJREpNSkNKGAggASgNEiEKC01IRkhPRERCT1BNGAwgASgL";
		buffer[3] = "MgwuRUNLSURMSUZBRkcSHAoGcmVhc29uGA8gASgOMgwuRktBTklCREpOS0dC";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ECKIDLIFAFGReflection.Descriptor,
			FKANIBDJNKGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKLLLKLEEAP), MKLLLKLEEAP.Parser, new string[4] { "IJDMECLJEBD", "DKAEIDJMJCJ", "MHFHODDBOPM", "Reason" }, null, null, null, null)
		}));
	}
}
