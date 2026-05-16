using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NJINCNAGALPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NJINCNAGALPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSklOQ05BR0FMUC5wcm90byI3CgtOSklOQ05BR0FMUBITCgtBT0tEQkRH" + "RENIQhgJIAEoDRITCgtDRUhPUEhKSERFRhgLIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NJINCNAGALP), NJINCNAGALP.Parser, new string[2] { "AOKDBDGDCHB", "CEHOPHJHDEF" }, null, null, null, null)
		}));
	}
}
