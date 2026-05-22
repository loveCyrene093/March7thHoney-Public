using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnTakeRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnTakeRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFQbGF5ZXJSZXR1cm5UYWtlUmV3YXJkU2NSc3AucHJvdG8aDkl0ZW1MaXN0" + "LnByb3RvIk4KG1BsYXllclJldHVyblRha2VSZXdhcmRTY1JzcBIeCgtFQkNB" + "RUZPTkRKQxgBIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYCiABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnTakeRewardScRsp), PlayerReturnTakeRewardScRsp.Parser, new string[2] { "EBCAEFONDJC", "Retcode" }, null, null, null, null)
		}));
	}
}
