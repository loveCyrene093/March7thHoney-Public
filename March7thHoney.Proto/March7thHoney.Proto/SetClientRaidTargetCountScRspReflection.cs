using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetClientRaidTargetCountScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetClientRaidTargetCountScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNTZXRDbGllbnRSYWlkVGFyZ2V0Q291bnRTY1JzcC5wcm90byJXCh1TZXRD" + "bGllbnRSYWlkVGFyZ2V0Q291bnRTY1JzcBIQCghwcm9ncmVzcxgBIAEoDRIT" + "CgtISkpNT09ISEtNSBgEIAEoDRIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetClientRaidTargetCountScRsp), SetClientRaidTargetCountScRsp.Parser, new string[3] { "Progress", "HJJMOOHHKMH", "Retcode" }, null, null, null, null)
		}));
	}
}
