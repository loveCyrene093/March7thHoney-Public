using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReEnterLastElementStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReEnterLastElementStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZUVudGVyTGFzdEVsZW1lbnRTdGFnZUNzUmVxLnByb3RvIjAKHFJlRW50" + "ZXJMYXN0RWxlbWVudFN0YWdlQ3NSZXESEAoIc3RhZ2VfaWQYDyABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReEnterLastElementStageCsReq), ReEnterLastElementStageCsReq.Parser, new string[1] { "StageId" }, null, null, null, null)
		}));
	}
}
