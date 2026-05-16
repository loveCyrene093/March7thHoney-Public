using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGNAFAEAIDNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGNAFAEAIDNReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFQR05BRkFFQUlETi5wcm90bxoRRkZLR09HTkNOQUoucHJvdG8iwgEKC1BH";
		buffer[1] = "TkFGQUVBSUROEhMKC0hMS0FGUENMTUVPGAIgASgIEhMKC0dHRklKRkRGR0NN";
		buffer[2] = "GAMgASgIEhMKC0NKT1BORkRCSkhEGAggASgNEhMKC0lNTE9FSEhBSk9JGAog";
		buffer[3] = "ASgIEhMKC1BHSFBLSENOUE1GGAsgASgNEhMKC0pKTktQQ0JLT0tCGA0gASgN";
		buffer[4] = "EhMKC0tMT05DSUdBRE5JGA8gASgIEiAKCWJ1ZmZfbGlzdBjUDSADKAsyDC5G";
		buffer[5] = "RktHT0dOQ05BSkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FFKGOGNCNAJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGNAFAEAIDN), PGNAFAEAIDN.Parser, new string[8] { "HLKAFPCLMEO", "GGFIJFDFGCM", "CJOPNFDBJHD", "IMLOEHHAJOI", "PGHPKHCNPMF", "JJNKPCBKOKB", "KLONCIGADNI", "BuffList" }, null, null, null, null)
		}));
	}
}
