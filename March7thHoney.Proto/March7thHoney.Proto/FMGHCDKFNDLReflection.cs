using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FMGHCDKFNDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FMGHCDKFNDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTUdIQ0RLRk5ETC5wcm90byI3CgtGTUdIQ0RLRk5ETBITCgtKS0FJQ01N" + "UEZCQhgHIAEoCBITCgtCQkRPQ0pHQUVFShgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FMGHCDKFNDL), FMGHCDKFNDL.Parser, new string[2] { "JKAICMMPFBB", "BBDOCJGAEEJ" }, null, null, null, null)
		}));
	}
}
