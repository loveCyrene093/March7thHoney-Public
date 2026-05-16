using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FFKCDBGNELOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FFKCDBGNELOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRktDREJHTkVMTy5wcm90bxoRQkxJSkVLS09JSkgucHJvdG8iMAoLRkZL" + "Q0RCR05FTE8SIQoLTkRJT0ZLSE9CS00YDSABKAsyDC5CTElKRUtLT0lKSEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BLIJEKKOIJHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FFKCDBGNELO), FFKCDBGNELO.Parser, new string[1] { "NDIOFKHOBKM" }, null, null, null, null)
		}));
	}
}
