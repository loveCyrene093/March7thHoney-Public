using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AcceptedPamMissionExpireCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AcceptedPamMissionExpireCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNBY2NlcHRlZFBhbU1pc3Npb25FeHBpcmVDc1JlcS5wcm90byI4Ch1BY2Nl" + "cHRlZFBhbU1pc3Npb25FeHBpcmVDc1JlcRIXCg9tYWluX21pc3Npb25faWQY" + "BiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AcceptedPamMissionExpireCsReq), AcceptedPamMissionExpireCsReq.Parser, new string[1] { "MainMissionId" }, null, null, null, null)
		}));
	}
}
