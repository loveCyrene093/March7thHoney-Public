using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPABAKNJAHMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPABAKNJAHMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUEFCQUtOSkFITS5wcm90bxoRSUVFUEdKSUtFRU0ucHJvdG8iNgoLRFBB" + "QkFLTkpBSE0SGgoEdHlwZRgBIAEoDjIMLklFRVBHSklLRUVNEgsKA2NudBgF" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { IEEPGJIKEEMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPABAKNJAHM), DPABAKNJAHM.Parser, new string[2] { "Type", "Cnt" }, null, null, null, null)
		}));
	}
}
