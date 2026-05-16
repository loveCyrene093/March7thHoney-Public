using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OMBNHGAJANJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OMBNHGAJANJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTUJOSEdBSkFOSi5wcm90byJgCgtPTUJOSEdBSkFOShITCgtORE9DSUtQ" + "TEtJRhgBIAEoDRITCgtEQ1BLUE5MS0dNTRgCIAEoDRISCgpzZWN0aW9uX2lk" + "GAMgASgNEhMKC0JOTEhJTUhGR0RLGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OMBNHGAJANJ), OMBNHGAJANJ.Parser, new string[4] { "NDOCIKPLKIF", "DCPKPNLKGMM", "SectionId", "BNLHIMHFGDK" }, null, null, null, null)
		}));
	}
}
