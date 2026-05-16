using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishCurTurnScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishCurTurnScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGaW5pc2hDdXJUdXJuU2NSc3AucHJvdG8iOgoSRmluaXNoQ3VyVHVyblNj" + "UnNwEhMKC0tET0lNRUhFRU9HGAsgASgNEg8KB3JldGNvZGUYDSABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishCurTurnScRsp), FinishCurTurnScRsp.Parser, new string[2] { "KDOIMEHEEOG", "Retcode" }, null, null, null, null)
		}));
	}
}
