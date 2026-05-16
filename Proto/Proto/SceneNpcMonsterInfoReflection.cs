using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneNpcMonsterInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneNpcMonsterInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChlTY2VuZU5wY01vbnN0ZXJJbmZvLnByb3RvGhlOcGNNb25zdGVyRXh0cmFJ";
		buffer[1] = "bmZvLnByb3RvGhFQRUNNRkJDQkxISC5wcm90byLHAQoTU2NlbmVOcGNNb25z";
		buffer[2] = "dGVySW5mbxIoCgpleHRyYV9pbmZvGAIgASgLMhQuTnBjTW9uc3RlckV4dHJh";
		buffer[3] = "SW5mbxITCgtES0dDTExMSUZOSBgEIAEoCBITCgt3b3JsZF9sZXZlbBgHIAEo";
		buffer[4] = "DRISCgptb25zdGVyX2lkGAsgASgNEiEKC0pKQVBCRkdEUExBGAwgASgLMgwu";
		buffer[5] = "UEVDTUZCQ0JMSEgSEAoIZXZlbnRfaWQYDSABKA0SEwoLRkRJSEdIR0VJT0gY";
		buffer[6] = "DiABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			NpcMonsterExtraInfoReflection.Descriptor,
			PECMFBCBLHHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneNpcMonsterInfo), SceneNpcMonsterInfo.Parser, new string[7] { "ExtraInfo", "DKGCLLLIFNH", "WorldLevel", "MonsterId", "JJAPBFGDPLA", "EventId", "FDIHGHGEIOH" }, null, null, null, null)
		}));
	}
}
