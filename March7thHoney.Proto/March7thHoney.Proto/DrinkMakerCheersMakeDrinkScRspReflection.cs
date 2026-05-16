using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DrinkMakerCheersMakeDrinkScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DrinkMakerCheersMakeDrinkScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiREcmlua01ha2VyQ2hlZXJzTWFrZURyaW5rU2NSc3AucHJvdG8aEU5DSUZE" + "RUhDTUJLLnByb3RvIlQKHkRyaW5rTWFrZXJDaGVlcnNNYWtlRHJpbmtTY1Jz" + "cBIhCgtKT05KUE1MSFBETxgDIAEoCzIMLk5DSUZERUhDTUJLEg8KB3JldGNv" + "ZGUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { NCIFDEHCMBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DrinkMakerCheersMakeDrinkScRsp), DrinkMakerCheersMakeDrinkScRsp.Parser, new string[2] { "JONJPMLHPDO", "Retcode" }, null, null, null, null)
		}));
	}
}
