using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KFGAPLDLHPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KFGAPLDLHPFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRkdBUExETEhQRi5wcm90byJACgtLRkdBUExETEhQRhILCgNudW0YCSAB" + "KA0SEwoLR1BFQUZBSkdDUEgYCyABKA0SDwoHaXRlbV9pZBgNIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KFGAPLDLHPF), KFGAPLDLHPF.Parser, new string[3] { "Num", "GPEAFAJGCPH", "ItemId" }, null, null, null, null)
		}));
	}
}
