using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyRollDiceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyRollDiceScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNb25vcG9seVJvbGxEaWNlU2NSc3AucHJvdG8iPQoVTW9ub3BvbHlSb2xs" + "RGljZVNjUnNwEhMKC0hKSEdOS09PSUxJGAMgASgNEg8KB3JldGNvZGUYByAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyRollDiceScRsp), MonopolyRollDiceScRsp.Parser, new string[2] { "HJHGNKOOILI", "Retcode" }, null, null, null, null)
		}));
	}
}
