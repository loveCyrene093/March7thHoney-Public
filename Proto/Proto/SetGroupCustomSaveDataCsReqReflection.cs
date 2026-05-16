using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGroupCustomSaveDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGroupCustomSaveDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTZXRHcm91cEN1c3RvbVNhdmVEYXRhQ3NSZXEucHJvdG8iaQobU2V0R3Jv" + "dXBDdXN0b21TYXZlRGF0YUNzUmVxEhEKCXNhdmVfZGF0YRgIIAEoCRIQCghl" + "bnRyeV9pZBgJIAEoDRITCgtpbnRlcmFjdF9pZBgMIAEoBBIQCghncm91cF9p" + "ZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGroupCustomSaveDataCsReq), SetGroupCustomSaveDataCsReq.Parser, new string[4] { "SaveData", "EntryId", "InteractId", "GroupId" }, null, null, null, null)
		}));
	}
}
