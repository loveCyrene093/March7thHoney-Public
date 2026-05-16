using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ComposeSelectedRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ComposeSelectedRelicCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "Ch9Db21wb3NlU2VsZWN0ZWRSZWxpY0NzUmVxLnByb3RvGhJJdGVtQ29zdERh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "dGEucHJvdG8i2QEKGUNvbXBvc2VTZWxlY3RlZFJlbGljQ3NSZXESGAoQY29t";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "cG9zZV9yZWxpY19pZBgBIAEoDRINCgVjb3VudBgCIAEoDRISCgpjb21wb3Nl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "X2lkGAMgASgNEigKEWNvbXBvc2VfaXRlbV9saXN0GAcgASgLMg0uSXRlbUNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "c3REYXRhEhUKDW1haW5fYWZmaXhfaWQYCyABKA0SGQoRc3ViX2FmZml4X2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "X2xpc3QYDCADKA0SIwoMd3JfaXRlbV9saXN0GA4gASgLMg0uSXRlbUNvc3RE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "YXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ComposeSelectedRelicCsReq), ComposeSelectedRelicCsReq.Parser, new string[7] { "ComposeRelicId", "Count", "ComposeId", "ComposeItemList", "MainAffixId", "SubAffixIdList", "WrItemList" }, null, null, null, null)
		}));
	}
}
