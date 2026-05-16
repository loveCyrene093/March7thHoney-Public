using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMIOBFIHNECReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMIOBFIHNECReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTUlPQkZJSE5FQy5wcm90byIiCgtDTUlPQkZJSE5FQxITCgtJREZCS0VL" + "QkFCRBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMIOBFIHNEC), CMIOBFIHNEC.Parser, new string[1] { "IDFBKEKBABD" }, null, null, null, null)
		}));
	}
}
