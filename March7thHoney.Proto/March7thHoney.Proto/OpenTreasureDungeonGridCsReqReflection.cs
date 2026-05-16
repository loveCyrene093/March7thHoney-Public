using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenTreasureDungeonGridCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenTreasureDungeonGridCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJPcGVuVHJlYXN1cmVEdW5nZW9uR3JpZENzUmVxLnByb3RvIkgKHE9wZW5U" + "cmVhc3VyZUR1bmdlb25HcmlkQ3NSZXESEwoLQ0pPUE5GREJKSEQYBSABKA0S" + "EwoLdGFyZ2V0X3NpZGUYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenTreasureDungeonGridCsReq), OpenTreasureDungeonGridCsReq.Parser, new string[2] { "CJOPNFDBJHD", "TargetSide" }, null, null, null, null)
		}));
	}
}
