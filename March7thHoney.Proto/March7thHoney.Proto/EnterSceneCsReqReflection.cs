using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSceneCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSceneCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChVFbnRlclNjZW5lQ3NSZXEucHJvdG8aFVNjZW5lSWRlbnRpZmllci5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "bxoMVmVjdG9yLnByb3RvIsIBCg9FbnRlclNjZW5lQ3NSZXESFAoMaXNfY2xv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "c2VfbWFwGAIgASgIEhAKCGVudHJ5X2lkGAQgASgNEhMKC3RlbGVwb3J0X2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "GAYgASgNEhMKC09NRktNR0tJSUtQGAggASgIEioKEHNjZW5lX2lkZW50aWZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "ZXIYCSABKAsyEC5TY2VuZUlkZW50aWZpZXISEwoLaW50ZXJhY3RfaWQYDCAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "KAQSHAoLQkxKTEJORlBIRkUYDSABKAsyBy5WZWN0b3JCFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			SceneIdentifierReflection.Descriptor,
			VectorReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSceneCsReq), EnterSceneCsReq.Parser, new string[7] { "IsCloseMap", "EntryId", "TeleportId", "OMFKMGKIIKP", "SceneIdentifier", "InteractId", "BLJLBNFPHFE" }, null, null, null, null)
		}));
	}
}
