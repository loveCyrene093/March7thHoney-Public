using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PNKDIILAIPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PNKDIILAIPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTktESUlMQUlQQi5wcm90bxoYRXJhRmxpcHBlckRhdGFMaXN0LnByb3Rv" + "IkEKC1BOS0RJSUxBSVBCEg8KB3JldGNvZGUYBCABKA0SIQoEZGF0YRgOIAEo" + "CzITLkVyYUZsaXBwZXJEYXRhTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { EraFlipperDataListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PNKDIILAIPB), PNKDIILAIPB.Parser, new string[2] { "Retcode", "Data" }, null, null, null, null)
		}));
	}
}
