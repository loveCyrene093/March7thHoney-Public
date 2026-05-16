using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUseForgeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUseForgeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHcmlkRmlnaHRVc2VGb3JnZUNzUmVxLnByb3RvIkcKFkdyaWRGaWdodFVz" + "ZUZvcmdlQ3NSZXESEQoJdW5pcXVlX2lkGAEgASgNEhoKEmZvcmdlX3Rhcmdl" + "dF9pbmRleBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUseForgeCsReq), GridFightUseForgeCsReq.Parser, new string[2] { "UniqueId", "ForgeTargetIndex" }, null, null, null, null)
		}));
	}
}
