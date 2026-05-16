using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IIJDPFOGCINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IIJDPFOGCINReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSUpEUEZPR0NJTi5wcm90bxoRQU5JT01LRENPRVAucHJvdG8iMAoLSUlK" + "RFBGT0dDSU4SIQoLSkZNSElMRUVGQ1AYDyABKAsyDC5BTklPTUtEQ09FUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ANIOMKDCOEPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IIJDPFOGCIN), IIJDPFOGCIN.Parser, new string[1] { "JFMHILEEFCP" }, null, null, null, null)
		}));
	}
}
