using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnTakeRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnTakeRelicScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBQbGF5ZXJSZXR1cm5UYWtlUmVsaWNTY1JzcC5wcm90bxoOSXRlbUxpc3Qu" + "cHJvdG8iXgoaUGxheWVyUmV0dXJuVGFrZVJlbGljU2NSc3ASDwoHcmV0Y29k" + "ZRgGIAEoDRIcCglpdGVtX2xpc3QYByABKAsyCS5JdGVtTGlzdBIRCglhdmF0" + "YXJfaWQYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnTakeRelicScRsp), PlayerReturnTakeRelicScRsp.Parser, new string[3] { "Retcode", "ItemList", "AvatarId" }, null, null, null, null)
		}));
	}
}
