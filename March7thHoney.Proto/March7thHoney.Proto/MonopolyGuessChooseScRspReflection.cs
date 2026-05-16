using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGuessChooseScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGuessChooseScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Nb25vcG9seUd1ZXNzQ2hvb3NlU2NSc3AucHJvdG8iQAoYTW9ub3BvbHlH" + "dWVzc0Nob29zZVNjUnNwEg8KB3JldGNvZGUYASABKA0SEwoLSUxJUEdBRUNQ" + "UEMYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGuessChooseScRsp), MonopolyGuessChooseScRsp.Parser, new string[2] { "Retcode", "ILIPGAECPPC" }, null, null, null, null)
		}));
	}
}
