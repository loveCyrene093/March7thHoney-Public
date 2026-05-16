using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HKJADKLIBEHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HKJADKLIBEHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIS0pBREtMSUJFSC5wcm90bxoRTUFHRktGQ01MSk0ucHJvdG8iMAoLSEtK" + "QURLTElCRUgSIQoLT0ZDS0hHTElOQUcYCCABKAsyDC5NQUdGS0ZDTUxKTUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MAGFKFCMLJMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HKJADKLIBEH), HKJADKLIBEH.Parser, new string[1] { "OFCKHGLINAG" }, null, null, null, null)
		}));
	}
}
