using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JHKBPIEOLFBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JHKBPIEOLFBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSEtCUElFT0xGQi5wcm90byJMCgtKSEtCUElFT0xGQhITCgtITkZER09N" + "RUlGTRgBIAEoDRITCgtJUEJJT1BGR0JPTRgIIAEoDRITCgtEQ1BLUE5MS0dN" + "TRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JHKBPIEOLFB), JHKBPIEOLFB.Parser, new string[3] { "HNFDGOMEIFM", "IPBIOPFGBOM", "DCPKPNLKGMM" }, null, null, null, null)
		}));
	}
}
