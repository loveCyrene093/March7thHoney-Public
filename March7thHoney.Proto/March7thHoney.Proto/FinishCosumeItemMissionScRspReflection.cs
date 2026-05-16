using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishCosumeItemMissionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishCosumeItemMissionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJGaW5pc2hDb3N1bWVJdGVtTWlzc2lvblNjUnNwLnByb3RvIkcKHEZpbmlz" + "aENvc3VtZUl0ZW1NaXNzaW9uU2NSc3ASDwoHcmV0Y29kZRgGIAEoDRIWCg5z" + "dWJfbWlzc2lvbl9pZBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishCosumeItemMissionScRsp), FinishCosumeItemMissionScRsp.Parser, new string[2] { "Retcode", "SubMissionId" }, null, null, null, null)
		}));
	}
}
