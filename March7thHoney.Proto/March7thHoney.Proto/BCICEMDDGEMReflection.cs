using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCICEMDDGEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCICEMDDGEMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ0lDRU1EREdFTS5wcm90bxoRRERLSEVGRUJGQUoucHJvdG8iPwoLQkNJ" + "Q0VNRERHRU0SIQoLTUpETUxPSUhMUEEYCiABKA4yDC5EREtIRUZFQkZBShIN" + "CgV2YWx1ZRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DDKHEFEBFAJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCICEMDDGEM), BCICEMDDGEM.Parser, new string[2] { "MJDMLOIHLPA", "Value" }, null, null, null, null)
		}));
	}
}
