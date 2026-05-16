using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GroupStateInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GroupStateInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRHcm91cFN0YXRlSW5mby5wcm90byJeCg5Hcm91cFN0YXRlSW5mbxIQCghn" + "cm91cF9pZBgBIAEoDRITCgtncm91cF9zdGF0ZRgEIAEoDRITCgtQR0pDTEJD" + "RVBCTRgJIAEoDRIQCghlbnRyeV9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GroupStateInfo), GroupStateInfo.Parser, new string[4] { "GroupId", "GroupState", "PGJCLBCEPBM", "EntryId" }, null, null, null, null)
		}));
	}
}
