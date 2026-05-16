using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGetRaffleTicketCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGetRaffleTicketCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNb25vcG9seUdldFJhZmZsZVRpY2tldENzUmVxLnByb3RvIjMKHE1vbm9w" + "b2x5R2V0UmFmZmxlVGlja2V0Q3NSZXESEwoLTUJNSUNDSkVCSkIYBCABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetRaffleTicketCsReq), MonopolyGetRaffleTicketCsReq.Parser, new string[1] { "MBMICCJEBJB" }, null, null, null, null)
		}));
	}
}
