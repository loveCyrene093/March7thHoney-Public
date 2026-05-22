using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGetRegionProgressScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGetRegionProgressScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRNb25vcG9seUdldFJlZ2lvblByb2dyZXNzU2NSc3AucHJvdG8iWwoeTW9u" + "b3BvbHlHZXRSZWdpb25Qcm9ncmVzc1NjUnNwEg8KB3JldGNvZGUYByABKA0S" + "EwoLRUtJTUxJQU1GSEUYCiABKA0SEwoLRktBS0NDSkNHQUYYDCABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetRegionProgressScRsp), MonopolyGetRegionProgressScRsp.Parser, new string[3] { "Retcode", "EKIMLIAMFHE", "FKAKCCJCGAF" }, null, null, null, null)
		}));
	}
}
