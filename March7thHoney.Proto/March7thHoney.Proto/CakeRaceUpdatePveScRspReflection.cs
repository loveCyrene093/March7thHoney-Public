using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceUpdatePveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceUpdatePveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDYWtlUmFjZVVwZGF0ZVB2ZVNjUnNwLnByb3RvIikKFkNha2VSYWNlVXBk" + "YXRlUHZlU2NSc3ASDwoHcmV0Y29kZRgBIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceUpdatePveScRsp), CakeRaceUpdatePveScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
