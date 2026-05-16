using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHBKANLBCCPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHBKANLBCCPReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFISEJLQU5MQkNDUC5wcm90bxoRSUZESlBESUtMREkucHJvdG8aEUlQSEZE";
		buffer[1] = "RUxDTkJELnByb3RvIrYBCgtISEJLQU5MQkNDUBINCgVsZXZlbBgBIAEoDRIT";
		buffer[2] = "CgtNUEdGR0tEQkFIThgCIAEoCBIhCgtDSUdGT0xMQ0tLSRgDIAMoCzIMLklG";
		buffer[3] = "REpQRElLTERJEhMKC0VGTExQUExDS0JCGAYgASgEEhMKC01PT09QQU1CT0ZL";
		buffer[4] = "GAggASgNEhMKC0dFRkdPSUdKSEZKGAwgASgEEiEKC0ZCSEdQUENLRUlDGA8g";
		buffer[5] = "AygLMgwuSVBIRkRFTENOQkRCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[6] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			IFDJPDIKLDIReflection.Descriptor,
			IPHFDELCNBDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHBKANLBCCP), HHBKANLBCCP.Parser, new string[7] { "Level", "MPGFGKDBAHN", "CIGFOLLCKKI", "EFLLPPLCKBB", "MOOOPAMBOFK", "GEFGOIGJHFJ", "FBHGPPCKEIC" }, null, null, null, null)
		}));
	}
}
