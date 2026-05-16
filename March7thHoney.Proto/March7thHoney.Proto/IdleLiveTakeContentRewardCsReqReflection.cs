using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveTakeContentRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveTakeContentRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRJZGxlTGl2ZVRha2VDb250ZW50UmV3YXJkQ3NSZXEucHJvdG8aEU1IR0RK" + "UE1FRkZOLnByb3RvIlcKHklkbGVMaXZlVGFrZUNvbnRlbnRSZXdhcmRDc1Jl" + "cRIhCgtNS0hESU5ER0hNRBgEIAEoDjIMLk1IR0RKUE1FRkZOEhIKCmNvbnRl" + "bnRfaWQYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MHGDJPMEFFNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveTakeContentRewardCsReq), IdleLiveTakeContentRewardCsReq.Parser, new string[2] { "MKHDINDGHMD", "ContentId" }, null, null, null, null)
		}));
	}
}
