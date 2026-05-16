using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainCakeCatchSearchScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainCakeCatchSearchScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch9UcmFpbkNha2VDYXRjaFNlYXJjaFNjUnNwLnByb3RvGhFMR0dBQkhQR1BE";
		buffer[1] = "RC5wcm90bxoRUEtJTE5ETkNBTUkucHJvdG8inAEKGVRyYWluQ2FrZUNhdGNo";
		buffer[2] = "U2VhcmNoU2NSc3ASDwoHcmV0Y29kZRgBIAEoDRITCgtPTUZDR0xKREZQRBgG";
		buffer[3] = "IAMoDRIhCgtCTEVESU9PSlBOTBgMIAEoCzIMLlBLSUxORE5DQU1JEhMKC0hD";
		buffer[4] = "SlBETkRPSEFNGA0gASgNEiEKC0tBTElCR0NPRE5GGA4gAygLMgwuTEdHQUJI";
		buffer[5] = "UEdQRERCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			LGGABHPGPDDReflection.Descriptor,
			PKILNDNCAMIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainCakeCatchSearchScRsp), TrainCakeCatchSearchScRsp.Parser, new string[5] { "Retcode", "OMFCGLJDFPD", "BLEDIOOJPNL", "HCJPDNDOHAM", "KALIBGCODNF" }, null, null, null, null)
		}));
	}
}
