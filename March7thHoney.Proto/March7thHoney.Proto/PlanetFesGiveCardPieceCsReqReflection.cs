using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesGiveCardPieceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesGiveCardPieceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFQbGFuZXRGZXNHaXZlQ2FyZFBpZWNlQ3NSZXEucHJvdG8iRwobUGxhbmV0" + "RmVzR2l2ZUNhcmRQaWVjZUNzUmVxEhMKC01HQUZERENHSlBNGAEgAygNEhMK" + "C3RlbGVwb3J0X2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGiveCardPieceCsReq), PlanetFesGiveCardPieceCsReq.Parser, new string[2] { "MGAFDDCGJPM", "TeleportId" }, null, null, null, null)
		}));
	}
}
