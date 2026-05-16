using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AOHPHEKEJMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AOHPHEKEJMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBT0hQSEVLRUpNQy5wcm90byIiCgtBT0hQSEVLRUpNQxITCgtCRURMTURI" + "Tk1CShgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AOHPHEKEJMC), AOHPHEKEJMC.Parser, new string[1] { "BEDLMDHNMBJ" }, null, null, null, null)
		}));
	}
}
