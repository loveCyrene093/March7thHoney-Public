using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGameGachaScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGameGachaScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNb25vcG9seUdhbWVHYWNoYVNjUnNwLnByb3RvIj4KFk1vbm9wb2x5R2Ft" + "ZUdhY2hhU2NSc3ASEwoLQU5JQURORkVNQUgYDCADKA0SDwoHcmV0Y29kZRgO" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGameGachaScRsp), MonopolyGameGachaScRsp.Parser, new string[2] { "ANIADNFEMAH", "Retcode" }, null, null, null, null)
		}));
	}
}
