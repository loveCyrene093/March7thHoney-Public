using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MOMAEPPEAJAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MOMAEPPEAJAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNT01BRVBQRUFKQS5wcm90bxoRTkpCSEtMQ0tIQksucHJvdG8iMAoLTU9N" + "QUVQUEVBSkESIQoLTUFPTkhEQ0NIUEUYDCABKAsyDC5OSkJIS0xDS0hCS0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NJBHKLCKHBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MOMAEPPEAJA), MOMAEPPEAJA.Parser, new string[1] { "MAONHDCCHPE" }, null, null, null, null)
		}));
	}
}
