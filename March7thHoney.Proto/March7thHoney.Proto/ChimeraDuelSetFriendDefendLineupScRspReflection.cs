using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelSetFriendDefendLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelSetFriendDefendLineupScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitDaGltZXJhRHVlbFNldEZyaWVuZERlZmVuZExpbmV1cFNjUnNwLnByb3Rv" + "IkYKJUNoaW1lcmFEdWVsU2V0RnJpZW5kRGVmZW5kTGluZXVwU2NSc3ASDAoE" + "c2xvdBgFIAEoDRIPCgdyZXRjb2RlGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelSetFriendDefendLineupScRsp), ChimeraDuelSetFriendDefendLineupScRsp.Parser, new string[2] { "Slot", "Retcode" }, null, null, null, null)
		}));
	}
}
