using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BDNFMEMPFHKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BDNFMEMPFHKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCRE5GTUVNUEZISy5wcm90byINCgtCRE5GTUVNUEZIS0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BDNFMEMPFHK), BDNFMEMPFHK.Parser, null, null, null, null, null)
		}));
	}
}
