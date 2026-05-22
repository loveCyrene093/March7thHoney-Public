using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OKIGCEPLMKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OKIGCEPLMKAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPS0lHQ0VQTE1LQS5wcm90byI3CgtPS0lHQ0VQTE1LQRITCgtJRE1FRkRF" + "Rk9LRxgFIAMoDRITCgtQRU5MTUVJSklGSxgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OKIGCEPLMKA), OKIGCEPLMKA.Parser, new string[2] { "IDMEFDEFOKG", "PENLMEIJIFK" }, null, null, null, null)
		}));
	}
}
