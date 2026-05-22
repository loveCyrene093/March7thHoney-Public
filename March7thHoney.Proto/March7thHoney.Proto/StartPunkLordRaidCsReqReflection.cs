using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartPunkLordRaidCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartPunkLordRaidCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTdGFydFB1bmtMb3JkUmFpZENzUmVxLnByb3RvIk4KFlN0YXJ0UHVua0xv" + "cmRSYWlkQ3NSZXESCwoDdWlkGAYgASgNEhIKCm1vbnN0ZXJfaWQYByABKA0S" + "EwoLR0VBTEpPSkNKRk4YDCABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartPunkLordRaidCsReq), StartPunkLordRaidCsReq.Parser, new string[3] { "Uid", "MonsterId", "GEALJOJCJFN" }, null, null, null, null)
		}));
	}
}
