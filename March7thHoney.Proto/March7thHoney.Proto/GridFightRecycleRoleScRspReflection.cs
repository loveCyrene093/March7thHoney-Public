using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRecycleRoleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRecycleRoleScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HcmlkRmlnaHRSZWN5Y2xlUm9sZVNjUnNwLnByb3RvIiwKGUdyaWRGaWdo" + "dFJlY3ljbGVSb2xlU2NSc3ASDwoHcmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRecycleRoleScRsp), GridFightRecycleRoleScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
