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
		buffer[0] = "CiBDYW5jZWxTeW5jRXhwaXJlZEl0ZW1Dc1JlcS5wcm90bxoRSk1HQ0RJQU5M";
		buffer[1] = "R0sucHJvdG8iYgoaQ2FuY2VsU3luY0V4cGlyZWRJdGVtQ3NSZXESGgoEdHlw";
		buffer[2] = "ZRgDIAEoDjIMLkpNR0NESUFOTEdLEhMKC0NPT09GRktJRE1DGAYgAygNEhMK";
		buffer[3] = "C0pMTEtOTkZBUEVFGA4gAygJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JMGCDIANLGKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CancelSyncExpiredItemCsReq), CancelSyncExpiredItemCsReq.Parser, new string[3] { "Type", "COOOFFKIDMC", "JLLKNNFAPEE" }, null, null, null, null)
		}));
	}
}
