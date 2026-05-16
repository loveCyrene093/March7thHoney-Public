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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFISEJLQU5MQkNDUC5wcm90bxoRSUZESlBESUtMREkucHJvdG8aEUlQSEZE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "RUxDTkJELnByb3RvIrYBCgtISEJLQU5MQkNDUBINCgVsZXZlbBgBIAEoDRIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "CgtNUEdGR0tEQkFIThgCIAEoCBIhCgtDSUdGT0xMQ0tLSRgDIAMoCzIMLklG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "REpQRElLTERJEhMKC0VGTExQUExDS0JCGAYgASgEEhMKC01PT09QQU1CT0ZL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "GAggASgNEhMKC0dFRkdPSUdKSEZKGAwgASgEEiEKC0ZCSEdQUENLRUlDGA8g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "AygLMgwuSVBIRkRFTENOQkRCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			IFDJPDIKLDIReflection.Descriptor,
			IPHFDELCNBDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHBKANLBCCP), HHBKANLBCCP.Parser, new string[7] { "Level", "MPGFGKDBAHN", "CIGFOLLCKKI", "EFLLPPLCKBB", "MOOOPAMBOFK", "GEFGOIGJHFJ", "FBHGPPCKEIC" }, null, null, null, null)
		}));
	}
}
