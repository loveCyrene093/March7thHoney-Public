using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ParkourStartLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ParkourStartLevelCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxQYXJrb3VyU3RhcnRMZXZlbENzUmVxLnByb3RvIj8KFlBhcmtvdXJTdGFy" + "dExldmVsQ3NSZXESEAoIbGV2ZWxfaWQYBiABKA0SEwoLSEhQRk5EQkdJSU8Y" + "CiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ParkourStartLevelCsReq), ParkourStartLevelCsReq.Parser, new string[2] { "LevelId", "HHPFNDBGIIO" }, null, null, null, null)
		}));
	}
}
