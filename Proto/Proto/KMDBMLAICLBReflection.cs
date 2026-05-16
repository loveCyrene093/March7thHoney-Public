using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KMDBMLAICLBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KMDBMLAICLBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTURCTUxBSUNMQi5wcm90byIiCgtLTURCTUxBSUNMQhITCgtCUEFPUENM" + "QkVLRxgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KMDBMLAICLB), KMDBMLAICLB.Parser, new string[1] { "BPAOPCLBEKG" }, null, null, null, null)
		}));
	}
}
