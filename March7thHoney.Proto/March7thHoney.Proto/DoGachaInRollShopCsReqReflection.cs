using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DoGachaInRollShopCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DoGachaInRollShopCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxEb0dhY2hhSW5Sb2xsU2hvcENzUmVxLnByb3RvIlkKFkRvR2FjaGFJblJv" + "bGxTaG9wQ3NSZXESEwoLZ2FjaGFfY291bnQYBiABKA0SFAoMZ2FjaGFfcmFu" + "ZG9tGAcgASgNEhQKDHJvbGxfc2hvcF9pZBgJIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaInRollShopCsReq), DoGachaInRollShopCsReq.Parser, new string[3] { "GachaCount", "GachaRandom", "RollShopId" }, null, null, null, null)
		}));
	}
}
