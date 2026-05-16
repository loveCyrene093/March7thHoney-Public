using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartRaidCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartRaidCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChRTdGFydFJhaWRDc1JlcS5wcm90bxoRRUVCUEhKQ05CRk8ucHJvdG8ilwEK";
		buffer[1] = "DlN0YXJ0UmFpZENzUmVxEiEKC0JEQkpLS09KT0RDGAIgAygLMgwuRUVCUEhK";
		buffer[2] = "Q05CRk8SDwoHaXNfc2F2ZRgDIAEoDRIWCg5wcm9wX2VudGl0eV9pZBgEIAEo";
		buffer[3] = "DRITCgt3b3JsZF9sZXZlbBgIIAEoDRIPCgdyYWlkX2lkGAkgASgNEhMKC2F2";
		buffer[4] = "YXRhcl9saXN0GAsgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[5] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EEBPHJCNBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartRaidCsReq), StartRaidCsReq.Parser, new string[6] { "BDBJKKOJODC", "IsSave", "PropEntityId", "WorldLevel", "RaidId", "AvatarList" }, null, null, null, null)
		}));
	}
}
