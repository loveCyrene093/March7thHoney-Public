using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartNodeBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartNodeBattleScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTdGFydE5vZGVCYXR0bGVTY1JzcC5wcm90bxoRR0tERUtKS09JSk4ucHJv" + "dG8iXwoUU3RhcnROb2RlQmF0dGxlU2NSc3ASEwoLR0lISEJKTUFHT0MYBSAB" + "KA0SIQoLT0lDRUpJTUVPTkcYByADKAsyDC5HS0RFS0pLT0lKThIPCgdyZXRj" + "b2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartNodeBattleScRsp), StartNodeBattleScRsp.Parser, new string[3] { "GIHHBJMAGOC", "OICEJIMEONG", "Retcode" }, null, null, null, null)
		}));
	}
}
