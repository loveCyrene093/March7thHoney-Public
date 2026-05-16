using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHcmlkRmlnaHRHZXREYXRhQ3NSZXEucHJvdG8iJwoVR3JpZEZpZ2h0R2V0" + "RGF0YUNzUmVxEg4KBnNlYXNvbhgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGetDataCsReq), GridFightGetDataCsReq.Parser, new string[1] { "Season" }, null, null, null, null)
		}));
	}
}
