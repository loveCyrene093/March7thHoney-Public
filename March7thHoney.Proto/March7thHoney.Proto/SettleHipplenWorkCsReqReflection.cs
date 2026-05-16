using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SettleHipplenWorkCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SettleHipplenWorkCsReqReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChxTZXR0bGVIaXBwbGVuV29ya0NzUmVxLnByb3RvGhFDSkVBSUhNSU5NSi5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "cm90bxoRS0pCR0FMQkNBRUcucHJvdG8aEU9KT0xQQUVQQkROLnByb3RvGhFP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "TkNJTUhFTUpERC5wcm90byK7AQoWU2V0dGxlSGlwcGxlbldvcmtDc1JlcRIj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "CgtQR0pJQUdHSEJCQRgCIAEoCzIMLkNKRUFJSE1JTk1KSAASIwoLTU5JTUFG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "QklHR1AYAyABKAsyDC5PTkNJTUhFTUpEREgAEiMKC1BQSk9KT0tPT0JGGAog";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "ASgLMgwuT0pPTFBBRVBCRE5IABIjCgtCSkdERk1KREpNSBgNIAEoCzIMLktK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "QkdBTEJDQUVHSABCDQoLSERBQ0NJRUlKRk9CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[4]
		{
			CJEAIHMINMJReflection.Descriptor,
			KJBGALBCAEGReflection.Descriptor,
			OJOLPAEPBDNReflection.Descriptor,
			ONCIMHEMJDDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SettleHipplenWorkCsReq), SettleHipplenWorkCsReq.Parser, new string[4] { "PGJIAGGHBBA", "MNIMAFBIGGP", "PPJOJOKOOBF", "BJGDFMJDJMH" }, new string[1] { "HDACCIEIJFO" }, null, null, null)
		}));
	}
}
