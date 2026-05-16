using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGetRafflePoolInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGetRafflePoolInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRNb25vcG9seUdldFJhZmZsZVBvb2xJbmZvU2NSc3AucHJvdG8aEUpMTEhN" + "QUhNQ0JGLnByb3RvIlQKHk1vbm9wb2x5R2V0UmFmZmxlUG9vbEluZm9TY1Jz" + "cBIPCgdyZXRjb2RlGAkgASgNEiEKC0ZCQUNLTERERUJMGA8gASgLMgwuSkxM" + "SE1BSE1DQkZCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { JLLHMAHMCBFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetRafflePoolInfoScRsp), MonopolyGetRafflePoolInfoScRsp.Parser, new string[2] { "Retcode", "FBACKLDDEBL" }, null, null, null, null)
		}));
	}
}
