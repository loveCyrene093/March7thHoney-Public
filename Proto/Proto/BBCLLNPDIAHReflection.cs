using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBCLLNPDIAHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBCLLNPDIAHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCQkNMTE5QRElBSC5wcm90bxoRRFBCR0dLQ01MR00ucHJvdG8ihAEKC0JC";
		buffer[1] = "Q0xMTlBESUFIEhMKC0hJQ1BBTU9JRk9FGAUgASgNEiEKC0JPTE1OTk1QTU5G";
		buffer[2] = "GAggAygLMgwuRFBCR0dLQ01MR00SEwoLSktDR0NBTUlGSUEYCiABKA0SEwoL";
		buffer[3] = "S0FBR0hBUEdMQ1AYCyABKA0SEwoLT0RBQ0hBRE9KQ0IYDyABKAhCFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DPBGGKCMLGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBCLLNPDIAH), BBCLLNPDIAH.Parser, new string[5] { "HICPAMOIFOE", "BOLMNNMPMNF", "JKCGCAMIFIA", "KAAGHAPGLCP", "ODACHADOJCB" }, null, null, null, null)
		}));
	}
}
