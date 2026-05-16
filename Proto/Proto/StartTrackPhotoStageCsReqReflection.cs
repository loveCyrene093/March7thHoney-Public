using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartTrackPhotoStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartTrackPhotoStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TdGFydFRyYWNrUGhvdG9TdGFnZUNzUmVxLnByb3RvIkIKGVN0YXJ0VHJh" + "Y2tQaG90b1N0YWdlQ3NSZXESEAoIc3RhZ2VfaWQYBiABKA0SEwoLTENIQUhF" + "Q0pQT0kYDCABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartTrackPhotoStageCsReq), StartTrackPhotoStageCsReq.Parser, new string[2] { "StageId", "LCHAHECJPOI" }, null, null, null, null)
		}));
	}
}
