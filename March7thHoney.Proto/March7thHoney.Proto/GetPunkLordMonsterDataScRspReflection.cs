using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPunkLordMonsterDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPunkLordMonsterDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRQdW5rTG9yZE1vbnN0ZXJEYXRhU2NSc3AucHJvdG8aEUNJS0pITE1P" + "T0lLLnByb3RvIlEKG0dldFB1bmtMb3JkTW9uc3RlckRhdGFTY1JzcBIhCgtQ" + "UE9FRERGRkVLSxgEIAMoCzIMLkNJS0pITE1PT0lLEg8KB3JldGNvZGUYBiAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { CIKJHLMOOIKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPunkLordMonsterDataScRsp), GetPunkLordMonsterDataScRsp.Parser, new string[2] { "PPOEDDFFEKK", "Retcode" }, null, null, null, null)
		}));
	}
}
