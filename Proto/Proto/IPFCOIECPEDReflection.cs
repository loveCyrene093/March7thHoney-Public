using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPFCOIECPEDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPFCOIECPEDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUEZDT0lFQ1BFRC5wcm90byINCgtJUEZDT0lFQ1BFREIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPFCOIECPED), IPFCOIECPED.Parser, null, null, null, null, null)
		}));
	}
}
