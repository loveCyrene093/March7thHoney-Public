using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JMHKLOPJGCPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JMHKLOPJGCPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTUhLTE9QSkdDUC5wcm90byI0CgtKTUhLTE9QSkdDUBITCgtDT09PRkZL" + "SURNQxgFIAEoDRIQCghncm91cF9pZBgHIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JMHKLOPJGCP), JMHKLOPJGCP.Parser, new string[2] { "COOOFFKIDMC", "GroupId" }, null, null, null, null)
		}));
	}
}
