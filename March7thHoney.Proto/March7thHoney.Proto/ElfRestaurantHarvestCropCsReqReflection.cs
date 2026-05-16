using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantHarvestCropCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantHarvestCropCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNFbGZSZXN0YXVyYW50SGFydmVzdENyb3BDc1JlcS5wcm90bxoRQkhITk1I" + "RERJREQucHJvdG8iQgodRWxmUmVzdGF1cmFudEhhcnZlc3RDcm9wQ3NSZXES" + "IQoLRk9QSFBKTkdQREUYASADKAsyDC5CSEhOTUhERElEREIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BHHNMHDDIDDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantHarvestCropCsReq), ElfRestaurantHarvestCropCsReq.Parser, new string[1] { "FOPHPJNGPDE" }, null, null, null, null)
		}));
	}
}
