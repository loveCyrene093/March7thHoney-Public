using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ABHOIALEGFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ABHOIALEGFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQkhPSUFMRUdGSS5wcm90bxoRR0lDTUhJQlBJR0kucHJvdG8iMAoLQUJI" + "T0lBTEVHRkkSIQoLSU5LQ0JNRk9KRE0YAiADKAsyDC5HSUNNSElCUElHSUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GICMHIBPIGIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ABHOIALEGFI), ABHOIALEGFI.Parser, new string[1] { "INKCBMFOJDM" }, null, null, null, null)
		}));
	}
}
