using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GIGAKCOMKOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GIGAKCOMKOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSUdBS0NPTUtPRy5wcm90bxoRUEJLUFBFQVBCT00ucHJvdG8iXwoLR0lH" + "QUtDT01LT0cSDAoEcmFuaxgBIAEoDRIbCgVzdGF0ZRgJIAEoDjIMLlBCS1BQ" + "RUFQQk9NEhMKC0pLUEdBQ0xLRUVDGAsgASgNEhAKCHNjb3JlX2lkGAwgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PBKPPEAPBOMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GIGAKCOMKOG), GIGAKCOMKOG.Parser, new string[4] { "Rank", "State", "JKPGACLKEEC", "ScoreId" }, null, null, null, null)
		}));
	}
}
