using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JBEENGDECOHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JBEENGDECOHReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFKQkVFTkdERUNPSC5wcm90byK1AQoLSkJFRU5HREVDT0gSEwoLQUhISkhI";
		buffer[1] = "T1BIUEoYAyADKA0SEwoLRkFQRktGSklFTEUYBCABKA0SEwoLSkNGRVBPS0lG";
		buffer[2] = "UEQYBSADKA0SEwoLSUVOQktJQUdQQkEYBiABKA0SEwoLQkJITUZBTktDQU8Y";
		buffer[3] = "ByADKA0SEwoLQktESU5PTkxBSEQYCCABKAgSEwoLQ0JKSUZDR0FOSUsYCiAB";
		buffer[4] = "KAgSEwoLSUVIS0RBSk5BTEUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[5] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JBEENGDECOH), JBEENGDECOH.Parser, new string[8] { "AHHJHHOPHPJ", "FAPFKFJIELE", "JCFEPOKIFPD", "IENBKIAGPBA", "BBHMFANKCAO", "BKDINONLAHD", "CBJIFCGANIK", "IEHKDAJNALE" }, null, null, null, null)
		}));
	}
}
