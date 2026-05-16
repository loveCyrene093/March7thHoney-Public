using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class COCHFHKKEBNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static COCHFHKKEBNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDT0NIRkhLS0VCTi5wcm90bxoRTkhES0xNSU1MS0MucHJvdG8iMAoLQ09D" + "SEZIS0tFQk4SIQoLSU1OT0pJREpCTkcYByABKAsyDC5OSERLTE1JTUxLQ0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NHDKLMIMLKCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(COCHFHKKEBN), COCHFHKKEBN.Parser, new string[1] { "IMNOJIDJBNG" }, null, null, null, null)
		}));
	}
}
