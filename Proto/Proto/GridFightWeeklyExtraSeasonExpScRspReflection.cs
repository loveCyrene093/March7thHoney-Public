using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightWeeklyExtraSeasonExpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightWeeklyExtraSeasonExpScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihHcmlkRmlnaHRXZWVrbHlFeHRyYVNlYXNvbkV4cFNjUnNwLnByb3RvIkEK" + "IkdyaWRGaWdodFdlZWtseUV4dHJhU2Vhc29uRXhwU2NSc3ASGwoTY3VyX3Rh" + "a2VuX2V4dHJhX2V4cBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightWeeklyExtraSeasonExpScRsp), GridFightWeeklyExtraSeasonExpScRsp.Parser, new string[1] { "CurTakenExtraExp" }, null, null, null, null)
		}));
	}
}
