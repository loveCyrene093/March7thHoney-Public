using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CancelSyncExpiredItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CancelSyncExpiredItemCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBDYW5jZWxTeW5jRXhwaXJlZEl0ZW1Dc1JlcS5wcm90bxoRSk1HQ0RJQU5M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "R0sucHJvdG8iYgoaQ2FuY2VsU3luY0V4cGlyZWRJdGVtQ3NSZXESGgoEdHlw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZRgDIAEoDjIMLkpNR0NESUFOTEdLEhMKC0NPT09GRktJRE1DGAYgAygNEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "C0pMTEtOTkZBUEVFGA4gAygJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { JMGCDIANLGKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CancelSyncExpiredItemCsReq), CancelSyncExpiredItemCsReq.Parser, new string[3] { "Type", "COOOFFKIDMC", "JLLKNNFAPEE" }, null, null, null, null)
		}));
	}
}
