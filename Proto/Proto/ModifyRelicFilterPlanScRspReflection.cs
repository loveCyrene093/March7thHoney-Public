using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ModifyRelicFilterPlanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ModifyRelicFilterPlanScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiBNb2RpZnlSZWxpY0ZpbHRlclBsYW5TY1JzcC5wcm90bxoRRk9GQkRCSkJF";
		buffer[1] = "SkUucHJvdG8aEU9CT0tESERPS0FELnByb3RvIsABChpNb2RpZnlSZWxpY0Zp";
		buffer[2] = "bHRlclBsYW5TY1JzcBIPCgdyZXRjb2RlGAMgASgNEhMKC0tLR0lFRU5DT0lD";
		buffer[3] = "GAggASgNEhMKC0VLTEtIUEdEUE9MGA4gASgDEiMKC0pISEhPTkpJS0dMGAEg";
		buffer[4] = "ASgLMgwuRk9GQkRCSkJFSkVIABIOCgRuYW1lGAIgASgJSAASIwoLSE1JSExE";
		buffer[5] = "UE1QT00YCiABKAsyDC5PQk9LREhET0tBREgAQg0KC0JQSUhGQUpDTE9DQhaq";
		buffer[6] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FOFBDBJBEJEReflection.Descriptor,
			OBOKDHDOKADReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ModifyRelicFilterPlanScRsp), ModifyRelicFilterPlanScRsp.Parser, new string[6] { "Retcode", "KKGIEENCOIC", "EKLKHPGDPOL", "JHHHONJIKGL", "Name", "HMIHLDPMPOM" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
