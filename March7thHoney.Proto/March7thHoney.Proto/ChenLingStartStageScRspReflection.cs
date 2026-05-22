using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingStartStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingStartStageScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGVuTGluZ1N0YXJ0U3RhZ2VTY1JzcC5wcm90bxoRRk1FTVBQTk5LSkgu" + "cHJvdG8iTQoXQ2hlbkxpbmdTdGFydFN0YWdlU2NSc3ASIQoLS0FGS1BIT0tE" + "TE0YAyABKAsyDC5GTUVNUFBOTktKSBIPCgdyZXRjb2RlGAkgASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { FMEMPPNNKJHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingStartStageScRsp), ChenLingStartStageScRsp.Parser, new string[2] { "KAFKPHOKDLM", "Retcode" }, null, null, null, null)
		}));
	}
}
