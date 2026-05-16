using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterTrialActivityStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterTrialActivityStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFbnRlclRyaWFsQWN0aXZpdHlTdGFnZUNzUmVxLnByb3RvIjAKHEVudGVy" + "VHJpYWxBY3Rpdml0eVN0YWdlQ3NSZXESEAoIc3RhZ2VfaWQYByABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterTrialActivityStageCsReq), EnterTrialActivityStageCsReq.Parser, new string[1] { "StageId" }, null, null, null, null)
		}));
	}
}
