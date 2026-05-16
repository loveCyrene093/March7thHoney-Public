using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurChallengePeakCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurChallengePeakCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRDdXJDaGFsbGVuZ2VQZWFrQ3NSZXEucHJvdG8iGgoYR2V0Q3VyQ2hh" + "bGxlbmdlUGVha0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurChallengePeakCsReq), GetCurChallengePeakCsReq.Parser, null, null, null, null, null)
		}));
	}
}
