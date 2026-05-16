using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingRestoreGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingRestoreGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNTd29yZFRyYWluaW5nUmVzdG9yZUdhbWVTY1JzcC5wcm90bxoRTE1CSERD" + "RlBQTEwucHJvdG8iUwodU3dvcmRUcmFpbmluZ1Jlc3RvcmVHYW1lU2NSc3AS" + "DwoHcmV0Y29kZRgDIAEoDRIhCgtCTUtBRUZBS05GShgHIAEoCzIMLkxNQkhE" + "Q0ZQUExMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LMBHDCFPPLLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingRestoreGameScRsp), SwordTrainingRestoreGameScRsp.Parser, new string[2] { "Retcode", "BMKAEFAKNFJ" }, null, null, null, null)
		}));
	}
}
