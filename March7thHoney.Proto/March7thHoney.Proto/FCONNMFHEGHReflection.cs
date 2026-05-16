using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCONNMFHEGHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCONNMFHEGHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ09OTk1GSEVHSC5wcm90byINCgtGQ09OTk1GSEVHSEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCONNMFHEGH), FCONNMFHEGH.Parser, null, null, null, null, null)
		}));
	}
}
