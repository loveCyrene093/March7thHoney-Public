using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBCJLDDEBHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBCJLDDEBHLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQkNKTERERUJITC5wcm90byI3CgtPQkNKTERERUJITBITCgtQTklETk9H" + "SE1CSBgBIAEoDRITCgtDTUFQQ0dHQUJKSRgIIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBCJLDDEBHL), OBCJLDDEBHL.Parser, new string[2] { "PNIDNOGHMBH", "CMAPCGGABJI" }, null, null, null, null)
		}));
	}
}
