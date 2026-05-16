using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FJIIPFCMJCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FJIIPFCMJCJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSklJUEZDTUpDSi5wcm90bxoRRE9HR0lETklOSlAucHJvdG8iMAoLRkpJ" + "SVBGQ01KQ0oSIQoLRU5QR0FHQk1IT0UYAyABKAsyDC5ET0dHSUROSU5KUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DOGGIDNINJPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FJIIPFCMJCJ), FJIIPFCMJCJ.Parser, new string[1] { "ENPGAGBMHOE" }, null, null, null, null)
		}));
	}
}
