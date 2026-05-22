using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKHPCMNPHKIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKHPCMNPHKIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQS0hQQ01OUEhLSS5wcm90bxoRTkRDSkFBT0xFQkEucHJvdG8iMAoLUEtI" + "UENNTlBIS0kSIQoLSUFJT0hMUEpJQUEYASADKAsyDC5ORENKQUFPTEVCQUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NDCJAAOLEBAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKHPCMNPHKI), PKHPCMNPHKI.Parser, new string[1] { "IAIOHLPJIAA" }, null, null, null, null)
		}));
	}
}
