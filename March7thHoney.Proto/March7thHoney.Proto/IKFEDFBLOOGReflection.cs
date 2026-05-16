using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IKFEDFBLOOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IKFEDFBLOOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJS0ZFREZCTE9PRy5wcm90bxoRT0hNSUlOS0xLQU0ucHJvdG8iMAoLSUtG" + "RURGQkxPT0cSIQoLTE1KS0lQRUpCRUIYBCADKAsyDC5PSE1JSU5LTEtBTUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OHMIINKLKAMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IKFEDFBLOOG), IKFEDFBLOOG.Parser, new string[1] { "LMJKIPEJBEB" }, null, null, null, null)
		}));
	}
}
