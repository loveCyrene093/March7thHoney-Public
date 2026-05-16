using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantBuyFieldCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantBuyFieldCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBFbGZSZXN0YXVyYW50QnV5RmllbGRDc1JlcS5wcm90byIxChpFbGZSZXN0" + "YXVyYW50QnV5RmllbGRDc1JlcRITCgtKQUZOQ09NR0FCRxgGIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantBuyFieldCsReq), ElfRestaurantBuyFieldCsReq.Parser, new string[1] { "JAFNCOMGABG" }, null, null, null, null)
		}));
	}
}
