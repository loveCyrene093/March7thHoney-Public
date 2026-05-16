using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGameRaiseRatioCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGameRaiseRatioCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNb25vcG9seUdhbWVSYWlzZVJhdGlvQ3NSZXEucHJvdG8iMgobTW9ub3Bv" + "bHlHYW1lUmFpc2VSYXRpb0NzUmVxEhMKC0tIRExNUEFLRUdGGAMgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGameRaiseRatioCsReq), MonopolyGameRaiseRatioCsReq.Parser, new string[1] { "KHDLMPAKEGF" }, null, null, null, null)
		}));
	}
}
