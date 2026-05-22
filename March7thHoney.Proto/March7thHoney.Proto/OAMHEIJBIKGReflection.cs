using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OAMHEIJBIKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OAMHEIJBIKGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQU1IRUlKQklLRy5wcm90bxoOSXRlbUxpc3QucHJvdG8iaQoLT0FNSEVJ" + "SkJJS0cSEwoLREFGRU5ER09BQkUYASABKA0SEwoLQ0FIRE9PSUhKS0IYBCAB" + "KA0SHgoLcmV3YXJkX2xpc3QYCSABKAsyCS5JdGVtTGlzdBIQCghwcm9ncmVz" + "cxgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OAMHEIJBIKG), OAMHEIJBIKG.Parser, new string[4] { "DAFENDGOABE", "CAHDOOIHJKB", "RewardList", "Progress" }, null, null, null, null)
		}));
	}
}
