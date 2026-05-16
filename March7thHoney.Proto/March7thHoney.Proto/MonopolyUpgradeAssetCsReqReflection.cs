using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyUpgradeAssetCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyUpgradeAssetCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Nb25vcG9seVVwZ3JhZGVBc3NldENzUmVxLnByb3RvIjAKGU1vbm9wb2x5" + "VXBncmFkZUFzc2V0Q3NSZXESEwoLSU5DSExITktIQ0gYBCABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyUpgradeAssetCsReq), MonopolyUpgradeAssetCsReq.Parser, new string[1] { "INCHLHNKHCH" }, null, null, null, null)
		}));
	}
}
