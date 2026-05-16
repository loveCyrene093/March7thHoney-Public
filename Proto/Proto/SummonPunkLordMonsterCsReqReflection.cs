using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SummonPunkLordMonsterCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SummonPunkLordMonsterCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTdW1tb25QdW5rTG9yZE1vbnN0ZXJDc1JlcS5wcm90byIcChpTdW1tb25Q" + "dW5rTG9yZE1vbnN0ZXJDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SummonPunkLordMonsterCsReq), SummonPunkLordMonsterCsReq.Parser, null, null, null, null, null)
		}));
	}
}
