using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CancelDirectDeliveryNoticeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CancelDirectDeliveryNoticeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDYW5jZWxEaXJlY3REZWxpdmVyeU5vdGljZUNzUmVxLnByb3RvIjYKH0Nh" + "bmNlbERpcmVjdERlbGl2ZXJ5Tm90aWNlQ3NSZXESEwoLT0VDQ1BLQU5ITU4Y" + "DiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CancelDirectDeliveryNoticeCsReq), CancelDirectDeliveryNoticeCsReq.Parser, new string[1] { "OECCPKANHMN" }, null, null, null, null)
		}));
	}
}
