using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KPJFOBOKKNOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KPJFOBOKKNOReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFLUEpGT0JPS0tOTy5wcm90byKgAQoLS1BKRk9CT0tLTk8SEwoLSERLSUhN";
		buffer[1] = "RUJOREMYBSABKAgSEwoLQUNNR0JOTkVBQ0oYByABKAgSEwoLREtLT0JQRE5D";
		buffer[2] = "TEMYCCABKA0SEwoLTFBIREJQQklMS0UYCiABKAgSEwoLQ0RLRURGUEVGSUoY";
		buffer[3] = "CyABKA0SEwoLTkhEREhNR0dLQk8YDCABKA0SEwoLTUZNSkJGREZNSEcYDiAB";
		buffer[4] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KPJFOBOKKNO), KPJFOBOKKNO.Parser, new string[7] { "HDKIHMEBNDC", "ACMGBNNEACJ", "DKKOBPDNCLC", "LPHDBPBILKE", "CDKEDFPEFIJ", "NHDDHMGGKBO", "MFMJBFDFMHG" }, null, null, null, null)
		}));
	}
}
