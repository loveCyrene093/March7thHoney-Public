using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceLoanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceLoanScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdDYWtlUmFjZUxvYW5TY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iVwoR" + "Q2FrZVJhY2VMb2FuU2NSc3ASEwoLTUZKR0hMREZKUEkYBiABKA0SDwoHcmV0" + "Y29kZRgKIAEoDRIcCglpdGVtX2xpc3QYDCABKAsyCS5JdGVtTGlzdEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceLoanScRsp), CakeRaceLoanScRsp.Parser, new string[3] { "MFJGHLDFJPI", "Retcode", "ItemList" }, null, null, null, null)
		}));
	}
}
