using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BMILHKCAKEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BMILHKCAKEAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTUlMSEtDQUtFQS5wcm90byINCgtCTUlMSEtDQUtFQUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BMILHKCAKEA), BMILHKCAKEA.Parser, null, null, null, null, null)
		}));
	}
}
