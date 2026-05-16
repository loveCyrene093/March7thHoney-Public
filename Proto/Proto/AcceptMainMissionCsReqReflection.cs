using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AcceptMainMissionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AcceptMainMissionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxBY2NlcHRNYWluTWlzc2lvbkNzUmVxLnByb3RvIjEKFkFjY2VwdE1haW5N" + "aXNzaW9uQ3NSZXESFwoPbWFpbl9taXNzaW9uX2lkGAwgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AcceptMainMissionCsReq), AcceptMainMissionCsReq.Parser, new string[1] { "MainMissionId" }, null, null, null, null)
		}));
	}
}
