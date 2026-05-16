using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MLCACCFABOHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MLCACCFABOHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTENBQ0NGQUJPSC5wcm90bxoRQkVORkpQRE1LRUQucHJvdG8iMAoLTUxD" + "QUNDRkFCT0gSIQoLQU5JQURORkVNQUgYDiADKAsyDC5CRU5GSlBETUtFREIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BENFJPDMKEDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MLCACCFABOH), MLCACCFABOH.Parser, new string[1] { "ANIADNFEMAH" }, null, null, null, null)
		}));
	}
}
