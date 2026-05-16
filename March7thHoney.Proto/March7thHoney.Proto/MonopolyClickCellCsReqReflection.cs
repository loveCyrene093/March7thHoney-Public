using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyClickCellCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyClickCellCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNb25vcG9seUNsaWNrQ2VsbENzUmVxLnByb3RvIj0KFk1vbm9wb2x5Q2xp" + "Y2tDZWxsQ3NSZXESEwoLRUlJQUdBQkFGRUMYCiABKA0SDgoGbWFwX2lkGAwg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyClickCellCsReq), MonopolyClickCellCsReq.Parser, new string[2] { "EIIAGABAFEC", "MapId" }, null, null, null, null)
		}));
	}
}
