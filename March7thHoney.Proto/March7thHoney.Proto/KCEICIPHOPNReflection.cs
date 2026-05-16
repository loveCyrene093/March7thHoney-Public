using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KCEICIPHOPNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KCEICIPHOPNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQ0VJQ0lQSE9QTi5wcm90bxoRTEhET0JPSEhLTUIucHJvdG8iMAoLS0NF" + "SUNJUEhPUE4SIQoLQklDUE5LT0NIR04YCCADKAsyDC5MSERPQk9ISEtNQkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LHDOBOHHKMBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KCEICIPHOPN), KCEICIPHOPN.Parser, new string[1] { "BICPNKOCHGN" }, null, null, null, null)
		}));
	}
}
