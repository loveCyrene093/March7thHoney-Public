using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKJCDLBIGDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKJCDLBIGDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFES0pDRExCSUdETC5wcm90byINCgtES0pDRExCSUdETEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DKJCDLBIGDL), DKJCDLBIGDL.Parser, null, null, null, null, null)
		}));
	}
}
