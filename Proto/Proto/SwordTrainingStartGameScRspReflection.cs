using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingStartGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingStartGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTd29yZFRyYWluaW5nU3RhcnRHYW1lU2NSc3AucHJvdG8aEUxNQkhEQ0ZQ" + "UExMLnByb3RvIlEKG1N3b3JkVHJhaW5pbmdTdGFydEdhbWVTY1JzcBIhCgtC" + "TUtBRUZBS05GShgGIAEoCzIMLkxNQkhEQ0ZQUExMEg8KB3JldGNvZGUYCCAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { LMBHDCFPPLLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingStartGameScRsp), SwordTrainingStartGameScRsp.Parser, new string[2] { "BMKAEFAKNFJ", "Retcode" }, null, null, null, null)
		}));
	}
}
