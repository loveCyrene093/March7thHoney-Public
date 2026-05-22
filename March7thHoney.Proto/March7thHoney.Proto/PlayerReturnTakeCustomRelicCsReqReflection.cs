using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnTakeCustomRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnTakeCustomRelicCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZQbGF5ZXJSZXR1cm5UYWtlQ3VzdG9tUmVsaWNDc1JlcS5wcm90byI1CiBQ" + "bGF5ZXJSZXR1cm5UYWtlQ3VzdG9tUmVsaWNDc1JlcRIRCglhdmF0YXJfaWQY" + "DiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnTakeCustomRelicCsReq), PlayerReturnTakeCustomRelicCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
