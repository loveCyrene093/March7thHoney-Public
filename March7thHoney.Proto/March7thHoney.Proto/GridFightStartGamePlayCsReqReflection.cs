using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightStartGamePlayCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightStartGamePlayCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRTdGFydEdhbWVQbGF5Q3NSZXEucHJvdG8iVwobR3JpZEZp" + "Z2h0U3RhcnRHYW1lUGxheUNzUmVxEg4KBnNlYXNvbhgDIAEoDRITCgtpc19v" + "dmVybG9jaxgNIAEoCBITCgtkaXZpc2lvbl9pZBgPIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightStartGamePlayCsReq), GridFightStartGamePlayCsReq.Parser, new string[3] { "Season", "IsOverlock", "DivisionId" }, null, null, null, null)
		}));
	}
}
