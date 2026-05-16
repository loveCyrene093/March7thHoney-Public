using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChenLingGameBoyDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChenLingGameBoyDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRDaGVuTGluZ0dhbWVCb3lEYXRhU2NSc3AucHJvdG8aEUVNSEFMSlBE" + "REJMLnByb3RvIlEKG0dldENoZW5MaW5nR2FtZUJveURhdGFTY1JzcBIhCgtN" + "QU9OSERDQ0hQRRgHIAEoCzIMLkVNSEFMSlBEREJMEg8KB3JldGNvZGUYDyAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { EMHALJPDDBLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChenLingGameBoyDataScRsp), GetChenLingGameBoyDataScRsp.Parser, new string[2] { "MAONHDCCHPE", "Retcode" }, null, null, null, null)
		}));
	}
}
