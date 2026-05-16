using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooDeleteCatScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooDeleteCatScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTcGFjZVpvb0RlbGV0ZUNhdFNjUnNwLnByb3RvIj4KFlNwYWNlWm9vRGVs" + "ZXRlQ2F0U2NSc3ASEwoLTklFSEhETEVBTk0YASADKA0SDwoHcmV0Y29kZRgM" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooDeleteCatScRsp), SpaceZooDeleteCatScRsp.Parser, new string[2] { "NIEHHDLEANM", "Retcode" }, null, null, null, null)
		}));
	}
}
