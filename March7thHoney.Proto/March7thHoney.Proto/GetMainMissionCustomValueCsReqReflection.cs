using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMainMissionCustomValueCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMainMissionCustomValueCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHZXRNYWluTWlzc2lvbkN1c3RvbVZhbHVlQ3NSZXEucHJvdG8iPgoeR2V0" + "TWFpbk1pc3Npb25DdXN0b21WYWx1ZUNzUmVxEhwKFG1haW5fbWlzc2lvbl9p" + "ZF9saXN0GAQgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMainMissionCustomValueCsReq), GetMainMissionCustomValueCsReq.Parser, new string[1] { "MainMissionIdList" }, null, null, null, null)
		}));
	}
}
