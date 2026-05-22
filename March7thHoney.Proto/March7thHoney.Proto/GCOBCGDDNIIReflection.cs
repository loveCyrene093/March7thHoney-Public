using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCOBCGDDNIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCOBCGDDNIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQ09CQ0dERE5JSS5wcm90bxoRQVBITEpQTEJPSUYucHJvdG8iMAoLR0NP" + "QkNHREROSUkSIQoLTEtOSEtGSUdCREYYCyABKAsyDC5BUEhMSlBMQk9JRkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { APHLJPLBOIFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GCOBCGDDNII), GCOBCGDDNII.Parser, new string[1] { "LKNHKFIGBDF" }, null, null, null, null)
		}));
	}
}
