using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MPDHIFKGDCLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MPDHIFKGDCLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNUERISUZLR0RDTC5wcm90byJdCgtNUERISUZLR0RDTBITCgtJRU1QR1BD" + "TkFBSBgBIAEoDRIQCghwcm9ncmVzcxgGIAEoDRITCgtLQktMTUxLRE5NUBgJ" + "IAEoDRISCgpoYXNfcGFzc2VkGA0gASgIQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MPDHIFKGDCL), MPDHIFKGDCL.Parser, new string[4] { "IEMPGPCNAAH", "Progress", "KBKLMLKDNMP", "HasPassed" }, null, null, null, null)
		}));
	}
}
