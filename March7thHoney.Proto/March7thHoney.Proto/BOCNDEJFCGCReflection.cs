using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BOCNDEJFCGCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BOCNDEJFCGCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCT0NOREVKRkNHQy5wcm90bxoRTkRDSkFBT0xFQkEucHJvdG8iMAoLQk9D" + "TkRFSkZDR0MSIQoLTkRJR0VISkJCUEsYBSABKAsyDC5ORENKQUFPTEVCQUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NDCJAAOLEBAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BOCNDEJFCGC), BOCNDEJFCGC.Parser, new string[1] { "NDIGEHJBBPK" }, null, null, null, null)
		}));
	}
}
