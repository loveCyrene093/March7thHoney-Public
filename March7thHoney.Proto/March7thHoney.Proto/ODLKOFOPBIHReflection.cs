using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ODLKOFOPBIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ODLKOFOPBIHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRExLT0ZPUEJJSC5wcm90bxoRSlBGSUVMRkVGSEQucHJvdG8iMAoLT0RM" + "S09GT1BCSUgSIQoLQkdER0dBTEFPRE8YAyABKAsyDC5KUEZJRUxGRUZIREIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JPFIELFEFHDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ODLKOFOPBIH), ODLKOFOPBIH.Parser, new string[1] { "BGDGGALAODO" }, null, null, null, null)
		}));
	}
}
