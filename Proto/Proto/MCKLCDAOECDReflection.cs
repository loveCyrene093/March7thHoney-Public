using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MCKLCDAOECDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MCKLCDAOECDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNQ0tMQ0RBT0VDRC5wcm90byKgAQoLTUNLTENEQU9FQ0QSEwoLS0hDSk9O";
		buffer[1] = "RkFQTUsYASABKAgSEwoLRkpJS0lQREpPUEsYAiABKA0SEwoLSklPRERBSE5N";
		buffer[2] = "RUwYAyABKAgSEwoLQlBESkdHQkdNTU0YBCABKAkSEwoLSk9PQ0RLSkZEQkEY";
		buffer[3] = "BSABKAgSEwoLUENDT0dDUEJGTEwYBiABKAgSEwoLQ0tISUZMQkZGTEMYByAB";
		buffer[4] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MCKLCDAOECD), MCKLCDAOECD.Parser, new string[7] { "KHCJONFAPMK", "FJIKIPDJOPK", "JIODDAHNMEL", "BPDJGGBGMMM", "JOOCDKJFDBA", "PCCOGCPBFLL", "CKHIFLBFFLC" }, null, null, null, null)
		}));
	}
}
