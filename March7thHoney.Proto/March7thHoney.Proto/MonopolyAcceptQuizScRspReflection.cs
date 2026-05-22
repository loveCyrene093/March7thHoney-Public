using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyAcceptQuizScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyAcceptQuizScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Nb25vcG9seUFjY2VwdFF1aXpTY1JzcC5wcm90bxoRSkNBREVITkRHTEYu" + "cHJvdG8iTQoXTW9ub3BvbHlBY2NlcHRRdWl6U2NSc3ASIQoLTU5DRk5JRUhN" + "S0sYBCABKAsyDC5KQ0FERUhOREdMRhIPCgdyZXRjb2RlGAYgASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { JCADEHNDGLFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyAcceptQuizScRsp), MonopolyAcceptQuizScRsp.Parser, new string[2] { "MNCFNIEHMKK", "Retcode" }, null, null, null, null)
		}));
	}
}
