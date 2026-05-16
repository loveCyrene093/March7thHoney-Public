using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyRogueShopBuffScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyRogueShopBuffScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtCdXlSb2d1ZVNob3BCdWZmU2NSc3AucHJvdG8aEVBITUJKS01LTURLLnBy" + "b3RvIksKFUJ1eVJvZ3VlU2hvcEJ1ZmZTY1JzcBIhCgtIS0dLTkVLS0pIQhgE" + "IAEoCzIMLlBITUJKS01LTURLEg8KB3JldGNvZGUYDCABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { PHMBJKMKMDKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyRogueShopBuffScRsp), BuyRogueShopBuffScRsp.Parser, new string[2] { "HKGKNEKKJHB", "Retcode" }, null, null, null, null)
		}));
	}
}
