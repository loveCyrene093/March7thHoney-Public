using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DailyFirstMeetPamCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DailyFirstMeetPamCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxEYWlseUZpcnN0TWVldFBhbUNzUmVxLnByb3RvIhgKFkRhaWx5Rmlyc3RN" + "ZWV0UGFtQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DailyFirstMeetPamCsReq), DailyFirstMeetPamCsReq.Parser, null, null, null, null, null)
		}));
	}
}
