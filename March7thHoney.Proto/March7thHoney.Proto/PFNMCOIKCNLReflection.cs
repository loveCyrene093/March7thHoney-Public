using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PFNMCOIKCNLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PFNMCOIKCNLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRk5NQ09JS0NOTC5wcm90byINCgtQRk5NQ09JS0NOTEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PFNMCOIKCNL), PFNMCOIKCNL.Parser, null, null, null, null, null)
		}));
	}
}
