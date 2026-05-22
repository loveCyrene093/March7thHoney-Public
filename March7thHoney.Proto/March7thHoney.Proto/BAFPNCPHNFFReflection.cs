using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAFPNCPHNFFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAFPNCPHNFFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQUZQTkNQSE5GRi5wcm90byI3CgtCQUZQTkNQSE5GRhITCgtDQ0JPRUxQ" + "R01JShgCIAEoDRITCgtFR0lQSkJKT0hMRRgLIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAFPNCPHNFF), BAFPNCPHNFF.Parser, new string[2] { "CCBOELPGMIJ", "EGIPJBJOHLE" }, null, null, null, null)
		}));
	}
}
