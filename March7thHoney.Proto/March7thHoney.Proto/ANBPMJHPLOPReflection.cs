using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ANBPMJHPLOPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ANBPMJHPLOPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTkJQTUpIUExPUC5wcm90byINCgtBTkJQTUpIUExPUEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ANBPMJHPLOP), ANBPMJHPLOP.Parser, null, null, null, null, null)
		}));
	}
}
