using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DAKDPHMIPDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DAKDPHMIPDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQUtEUEhNSVBETC5wcm90byINCgtEQUtEUEhNSVBETEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DAKDPHMIPDL), DAKDPHMIPDL.Parser, null, null, null, null, null)
		}));
	}
}
