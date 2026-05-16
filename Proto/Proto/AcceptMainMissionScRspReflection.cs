using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AcceptMainMissionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AcceptMainMissionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxBY2NlcHRNYWluTWlzc2lvblNjUnNwLnByb3RvIkIKFkFjY2VwdE1haW5N" + "aXNzaW9uU2NSc3ASFwoPbWFpbl9taXNzaW9uX2lkGAQgASgNEg8KB3JldGNv" + "ZGUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AcceptMainMissionScRsp), AcceptMainMissionScRsp.Parser, new string[2] { "MainMissionId", "Retcode" }, null, null, null, null)
		}));
	}
}
