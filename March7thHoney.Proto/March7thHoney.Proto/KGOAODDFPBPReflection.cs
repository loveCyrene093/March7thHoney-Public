using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KGOAODDFPBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KGOAODDFPBPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLR09BT0RERlBCUC5wcm90byIfCgtLR09BT0RERlBCUBIQCghldmVudF9p" + "ZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KGOAODDFPBP), KGOAODDFPBP.Parser, new string[1] { "EventId" }, null, null, null, null)
		}));
	}
}
