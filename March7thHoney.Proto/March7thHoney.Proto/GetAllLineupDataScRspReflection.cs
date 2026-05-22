using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAllLineupDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAllLineupDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRBbGxMaW5ldXBEYXRhU2NSc3AucHJvdG8aEExpbmV1cEluZm8ucHJv" + "dG8iXQoVR2V0QWxsTGluZXVwRGF0YVNjUnNwEg8KB3JldGNvZGUYBiABKA0S" + "IAoLbGluZXVwX2xpc3QYCiADKAsyCy5MaW5ldXBJbmZvEhEKCWN1cl9pbmRl" + "eBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LineupInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAllLineupDataScRsp), GetAllLineupDataScRsp.Parser, new string[3] { "Retcode", "LineupList", "CurIndex" }, null, null, null, null)
		}));
	}
}
