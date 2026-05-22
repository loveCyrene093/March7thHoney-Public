using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMissionStatusCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMissionStatusCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRNaXNzaW9uU3RhdHVzQ3NSZXEucHJvdG8iUgoVR2V0TWlzc2lvblN0" + "YXR1c0NzUmVxEhwKFG1haW5fbWlzc2lvbl9pZF9saXN0GAUgAygNEhsKE3N1" + "Yl9taXNzaW9uX2lkX2xpc3QYDSADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionStatusCsReq), GetMissionStatusCsReq.Parser, new string[2] { "MainMissionIdList", "SubMissionIdList" }, null, null, null, null)
		}));
	}
}
