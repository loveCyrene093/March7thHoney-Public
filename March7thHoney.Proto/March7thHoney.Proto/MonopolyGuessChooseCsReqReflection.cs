using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGuessChooseCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGuessChooseCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Nb25vcG9seUd1ZXNzQ2hvb3NlQ3NSZXEucHJvdG8iLwoYTW9ub3BvbHlH" + "dWVzc0Nob29zZUNzUmVxEhMKC0lMSVBHQUVDUFBDGAYgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGuessChooseCsReq), MonopolyGuessChooseCsReq.Parser, new string[1] { "ILIPGAECPPC" }, null, null, null, null)
		}));
	}
}
