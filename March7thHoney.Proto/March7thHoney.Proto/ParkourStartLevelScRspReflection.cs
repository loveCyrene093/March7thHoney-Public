using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ParkourStartLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ParkourStartLevelScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxQYXJrb3VyU3RhcnRMZXZlbFNjUnNwLnByb3RvIlAKFlBhcmtvdXJTdGFy" + "dExldmVsU2NSc3ASEAoIbGV2ZWxfaWQYAyABKA0SEwoLSEhQRk5EQkdJSU8Y" + "BCABKA0SDwoHcmV0Y29kZRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ParkourStartLevelScRsp), ParkourStartLevelScRsp.Parser, new string[3] { "LevelId", "HHPFNDBGIIO", "Retcode" }, null, null, null, null)
		}));
	}
}
