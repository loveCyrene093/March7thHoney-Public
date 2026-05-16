using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainVisitorBehaviorFinishCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainVisitorBehaviorFinishCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVUcmFpblZpc2l0b3JCZWhhdmlvckZpbmlzaENzUmVxLnByb3RvIjUKH1Ry" + "YWluVmlzaXRvckJlaGF2aW9yRmluaXNoQ3NSZXESEgoKdmlzaXRvcl9pZBgN" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainVisitorBehaviorFinishCsReq), TrainVisitorBehaviorFinishCsReq.Parser, new string[1] { "VisitorId" }, null, null, null, null)
		}));
	}
}
