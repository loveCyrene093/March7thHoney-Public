using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ECMFDCIIIHJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ECMFDCIIIHJReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFFQ01GRENJSUlISi5wcm90bxoRQkREQkFLQk9NS1AucHJvdG8aEUNBSU9E";
		buffer[1] = "Q05FTUhPLnByb3RvItEBCgtFQ01GRENJSUlIShIhCgtDSUdDS0tHTUxJRBgB";
		buffer[2] = "IAMoCzIMLkJEREJBS0JPTUtQEhMKC0VNQkdBRU1IRFBBGAIgAygNEiEKC0JE";
		buffer[3] = "QU9DTk5LT0pGGAQgAygLMgwuQ0FJT0RDTkVNSE8SEwoLRkhBRElPUERNSFAY";
		buffer[4] = "ByABKA0SEwoLTE1FRUpKTk9GSUUYCyABKA0SEwoLUEVKTVBITVBQS08YDCAB";
		buffer[5] = "KA0SEwoLTk1DQUNOTk5CTkQYDiABKA0SEwoLRElEUEFCSlBETEoYDyABKAhC";
		buffer[6] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BDDBAKBOMKPReflection.Descriptor,
			CAIODCNEMHOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ECMFDCIIIHJ), ECMFDCIIIHJ.Parser, new string[8] { "CIGCKKGMLID", "EMBGAEMHDPA", "BDAOCNNKOJF", "FHADIOPDMHP", "LMEEJJNOFIE", "PEJMPHMPPKO", "NMCACNNNBND", "DIDPABJPDLJ" }, null, null, null, null)
		}));
	}
}
