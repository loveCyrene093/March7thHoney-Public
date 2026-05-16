using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReStartChallengePeakCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReStartChallengePeakCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZVN0YXJ0Q2hhbGxlbmdlUGVha0NzUmVxLnByb3RvIhsKGVJlU3RhcnRD" + "aGFsbGVuZ2VQZWFrQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReStartChallengePeakCsReq), ReStartChallengePeakCsReq.Parser, null, null, null, null, null)
		}));
	}
}
