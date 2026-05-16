using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantDataChangeNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantDataChangeNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNFbGZSZXN0YXVyYW50RGF0YUNoYW5nZU5vdGlmeS5wcm90bxoRR0ZLTktF" + "TUpQQkEucHJvdG8iQgodRWxmUmVzdGF1cmFudERhdGFDaGFuZ2VOb3RpZnkS" + "IQoLQ0pGQkxITlBIQUsYDyADKAsyDC5HRktOS0VNSlBCQUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GFKNKEMJPBAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantDataChangeNotify), ElfRestaurantDataChangeNotify.Parser, new string[1] { "CJFBLHNPHAK" }, null, null, null, null)
		}));
	}
}
