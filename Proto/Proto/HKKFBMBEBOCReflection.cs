using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HKKFBMBEBOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HKKFBMBEBOCReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFIS0tGQk1CRUJPQy5wcm90bxoRREFQUEZKTEVQTEgucHJvdG8aEU1ETk5H";
		buffer[1] = "Q0dJQUtPLnByb3RvGhFNSkZKRU1MUEtKRS5wcm90byKLAQoLSEtLRkJNQkVC";
		buffer[2] = "T0MSIwoLQ0dDSkxIRkxFUE4YBCABKAsyDC5NSkZKRU1MUEtKRUgAEiMKC0xG";
		buffer[3] = "UElOREZBQUhLGAsgASgLMgwuREFQUEZKTEVQTEhIABIjCgtQSklHSE5GSEZL";
		buffer[4] = "RBgPIAEoCzIMLk1ETk5HQ0dJQUtPSABCDQoLUEFOQUpCSEtBS09CFqoCE01h";
		buffer[5] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			DAPPFJLEPLHReflection.Descriptor,
			MDNNGCGIAKOReflection.Descriptor,
			MJFJEMLPKJEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HKKFBMBEBOC), HKKFBMBEBOC.Parser, new string[3] { "CGCJLHFLEPN", "LFPINDFAAHK", "PJIGHNFHFKD" }, new string[1] { "PANAJBHKAKO" }, null, null, null)
		}));
	}
}
