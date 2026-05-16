using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBOCLMGMNEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBOCLMGMNEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQk9DTE1HTU5FQi5wcm90byI4CgtCQk9DTE1HTU5FQhIUCgxnYWNoYV9y" + "YW5kb20YBiABKA0SEwoLTkFJUExEUEpISUkYCSABKAhCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBOCLMGMNEB), BBOCLMGMNEB.Parser, new string[2] { "GachaRandom", "NAIPLDPJHII" }, null, null, null, null)
		}));
	}
}
