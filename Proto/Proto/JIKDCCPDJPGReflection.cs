using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JIKDCCPDJPGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JIKDCCPDJPGReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFKSUtEQ0NQREpQRy5wcm90bxoRS0lOSExNSU1ESUcucHJvdG8aEU5BS0dN";
		buffer[1] = "R0hMS0ZQLnByb3RvIrcBCgtKSUtEQ0NQREpQRxIhCgtMR0lJS0hDS0JNRRgB";
		buffer[2] = "IAMoCzIMLktJTkhMTUlNRElHEhMKC0ZCQ0pDS0VBSENNGAMgASgNEg4KBmlz";
		buffer[3] = "X3dpbhgFIAEoCBIhCgtERU1HQkpDSkdOTxgHIAEoDjIMLk5BS0dNR0hMS0ZQ";
		buffer[4] = "EhMKC0RIRktPS0pJQk5FGA0gASgFEhMKC0FLR0xNQk5LSExHGA4gASgNEhMK";
		buffer[5] = "C05ITEdPQ0dNS0JQGA8gASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[6] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			KINHLMIMDIGReflection.Descriptor,
			NAKGMGHLKFPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JIKDCCPDJPG), JIKDCCPDJPG.Parser, new string[7] { "LGIIKHCKBME", "FBCJCKEAHCM", "IsWin", "DEMGBJCJGNO", "DHFKOKJIBNE", "AKGLMBNKHLG", "NHLGOCGMKBP" }, null, null, null, null)
		}));
	}
}
