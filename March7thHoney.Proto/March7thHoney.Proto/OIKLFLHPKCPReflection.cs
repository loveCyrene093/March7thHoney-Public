using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OIKLFLHPKCPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OIKLFLHPKCPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSUtMRkxIUEtDUC5wcm90byINCgtPSUtMRkxIUEtDUEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OIKLFLHPKCP), OIKLFLHPKCP.Parser, null, null, null, null, null)
		}));
	}
}
