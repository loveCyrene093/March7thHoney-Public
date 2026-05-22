using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOfferingRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOfferingRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlT2ZmZXJpbmdSZXdhcmRDc1JlcS5wcm90byJxChdUYWtlT2ZmZXJp" + "bmdSZXdhcmRDc1JlcRIhChlpbnRlcmFjdGVkX3Byb3BfZW50aXR5X2lkGAcg" + "ASgNEh4KFnRha2VfcmV3YXJkX2xldmVsX2xpc3QYDCADKA0SEwoLb2ZmZXJp" + "bmdfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOfferingRewardCsReq), TakeOfferingRewardCsReq.Parser, new string[3] { "InteractedPropEntityId", "TakeRewardLevelList", "OfferingId" }, null, null, null, null)
		}));
	}
}
