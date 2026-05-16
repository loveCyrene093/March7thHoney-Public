using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveChallengeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveChallengeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlMZWF2ZUNoYWxsZW5nZUNzUmVxLnByb3RvIhUKE0xlYXZlQ2hhbGxlbmdl" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveChallengeCsReq), LeaveChallengeCsReq.Parser, null, null, null, null, null)
		}));
	}
}
