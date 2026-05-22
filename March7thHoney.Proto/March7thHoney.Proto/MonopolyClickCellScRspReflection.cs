using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyClickCellScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyClickCellScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNb25vcG9seUNsaWNrQ2VsbFNjUnNwLnByb3RvIk4KFk1vbm9wb2x5Q2xp" + "Y2tDZWxsU2NSc3ASDgoGbWFwX2lkGAMgASgNEhMKC0VJSUFHQUJBRkVDGAYg" + "ASgNEg8KB3JldGNvZGUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyClickCellScRsp), MonopolyClickCellScRsp.Parser, new string[3] { "MapId", "EIIAGABAFEC", "Retcode" }, null, null, null, null)
		}));
	}
}
