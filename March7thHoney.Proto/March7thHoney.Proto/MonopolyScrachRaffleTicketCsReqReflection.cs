using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyScrachRaffleTicketCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyScrachRaffleTicketCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVNb25vcG9seVNjcmFjaFJhZmZsZVRpY2tldENzUmVxLnByb3RvIksKH01v" + "bm9wb2x5U2NyYWNoUmFmZmxlVGlja2V0Q3NSZXESEwoLTUJNSUNDSkVCSkIY" + "BCABKA0SEwoLQ0JPTUhDRE5FREcYCiABKARCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyScrachRaffleTicketCsReq), MonopolyScrachRaffleTicketCsReq.Parser, new string[2] { "MBMICCJEBJB", "CBOMHCDNEDG" }, null, null, null, null)
		}));
	}
}
