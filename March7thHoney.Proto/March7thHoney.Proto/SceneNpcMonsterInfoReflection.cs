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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChlTY2VuZU5wY01vbnN0ZXJJbmZvLnByb3RvGhlOcGNNb25zdGVyRXh0cmFJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "bmZvLnByb3RvGhFQRUNNRkJDQkxISC5wcm90byLHAQoTU2NlbmVOcGNNb25z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "dGVySW5mbxIoCgpleHRyYV9pbmZvGAIgASgLMhQuTnBjTW9uc3RlckV4dHJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "SW5mbxITCgtES0dDTExMSUZOSBgEIAEoCBITCgt3b3JsZF9sZXZlbBgHIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "DRISCgptb25zdGVyX2lkGAsgASgNEiEKC0pKQVBCRkdEUExBGAwgASgLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "UEVDTUZCQ0JMSEgSEAoIZXZlbnRfaWQYDSABKA0SEwoLRkRJSEdIR0VJT0gY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "DiABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			NpcMonsterExtraInfoReflection.Descriptor,
			PECMFBCBLHHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneNpcMonsterInfo), SceneNpcMonsterInfo.Parser, new string[7] { "ExtraInfo", "DKGCLLLIFNH", "WorldLevel", "MonsterId", "JJAPBFGDPLA", "EventId", "FDIHGHGEIOH" }, null, null, null, null)
		}));
	}
}
