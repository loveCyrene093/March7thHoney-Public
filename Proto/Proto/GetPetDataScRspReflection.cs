using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPetDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHZXRQZXREYXRhU2NSc3AucHJvdG8iTwoPR2V0UGV0RGF0YVNjUnNwEhIK" + "CmN1cl9wZXRfaWQYASABKA0SFwoPdW5sb2NrZWRfcGV0X2lkGAYgAygNEg8K" + "B3JldGNvZGUYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPetDataScRsp), GetPetDataScRsp.Parser, new string[3] { "CurPetId", "UnlockedPetId", "Retcode" }, null, null, null, null)
		}));
	}
}
