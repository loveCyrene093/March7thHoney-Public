using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OHMIINKLKAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OHMIINKLKAMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSE1JSU5LTEtBTS5wcm90byI2CgtPSE1JSU5LTEtBTRITCgtEQ1BLUE5M" + "S0dNTRgGIAEoDRISCgpzZWN0aW9uX2lkGAggASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OHMIINKLKAM), OHMIINKLKAM.Parser, new string[2] { "DCPKPNLKGMM", "SectionId" }, null, null, null, null)
		}));
	}
}
