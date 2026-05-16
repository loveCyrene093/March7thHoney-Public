using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurLineupDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurLineupDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRDdXJMaW5ldXBEYXRhU2NSc3AucHJvdG8aEExpbmV1cEluZm8ucHJv" + "dG8iRQoVR2V0Q3VyTGluZXVwRGF0YVNjUnNwEhsKBmxpbmV1cBgBIAEoCzIL" + "LkxpbmV1cEluZm8SDwoHcmV0Y29kZRgLIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LineupInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurLineupDataScRsp), GetCurLineupDataScRsp.Parser, new string[2] { "Lineup", "Retcode" }, null, null, null, null)
		}));
	}
}
