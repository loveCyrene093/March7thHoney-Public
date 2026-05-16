using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeV2LevelEndCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeV2LevelEndCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch9NYXRjaFRocmVlVjJMZXZlbEVuZENzUmVxLnByb3RvGhFHS0RFS0pLT0lK";
		buffer[1] = "Ti5wcm90byLHAQoZTWF0Y2hUaHJlZVYyTGV2ZWxFbmRDc1JlcRIhCgtCSUJH";
		buffer[2] = "SElDSURLUBgBIAMoCzIMLkdLREVLSktPSUpOEhMKC0JDTVBGSktIREJHGAQg";
		buffer[3] = "ASgNEhAKCGxldmVsX2lkGAcgASgNEhMKC1BNSkROT05NS0lCGAkgASgNEgwK";
		buffer[4] = "BHV1aWQYCiABKAkSEwoLTkxPQ0RITUxHSkgYCyABKA0SEwoLQUZNR0pPTEZL";
		buffer[5] = "SEoYDSABKA0SEwoLQ09OSkRES0FGS08YDyADKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[6] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeV2LevelEndCsReq), MatchThreeV2LevelEndCsReq.Parser, new string[8] { "BIBGHICIDKP", "BCMPFJKHDBG", "LevelId", "PMJDNONMKIB", "Uuid", "NLOCDHMLGJH", "AFMGJOLFKHJ", "CONJDDKAFKO" }, null, null, null, null)
		}));
	}
}
