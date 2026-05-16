using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGameBingoFlipCardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGameBingoFlipCardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRNb25vcG9seUdhbWVCaW5nb0ZsaXBDYXJkQ3NSZXEucHJvdG8iNQoeTW9u" + "b3BvbHlHYW1lQmluZ29GbGlwQ2FyZENzUmVxEhMKC05CRkxDTkhGRUZNGAog" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGameBingoFlipCardCsReq), MonopolyGameBingoFlipCardCsReq.Parser, new string[1] { "NBFLCNHFEFM" }, null, null, null, null)
		}));
	}
}
