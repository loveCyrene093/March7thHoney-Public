using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPNAEODCPDDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPNAEODCPDDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUE5BRU9EQ1BERC5wcm90byIZCgtJUE5BRU9EQ1BERBIKCgJpZBgPIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPNAEODCPDD), IPNAEODCPDD.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
