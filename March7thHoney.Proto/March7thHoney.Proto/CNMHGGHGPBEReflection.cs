using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNMHGGHGPBEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNMHGGHGPBEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTk1IR0dIR1BCRS5wcm90byIiCgtDTk1IR0dIR1BCRRITCgtFRFBGS0lE" + "RUhEUBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNMHGGHGPBE), CNMHGGHGPBE.Parser, new string[1] { "EDPFKIDEHDP" }, null, null, null, null)
		}));
	}
}
