using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeMultipleExpeditionRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeMultipleExpeditionRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CidUYWtlTXVsdGlwbGVFeHBlZGl0aW9uUmV3YXJkU2NSc3AucHJvdG8aDkl0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZW1MaXN0LnByb3RvIn4KIVRha2VNdWx0aXBsZUV4cGVkaXRpb25SZXdhcmRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Y1JzcBITCgtLQU1CQkZERUJBTRgIIAEoAxIPCgdyZXRjb2RlGAsgASgNEh4K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "C0hBTEZHTEdMRExPGAwgAygLMgkuSXRlbUxpc3QSEwoLQU5NSEtEQU5OREwY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "DyADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeMultipleExpeditionRewardScRsp), TakeMultipleExpeditionRewardScRsp.Parser, new string[4] { "KAMBBFDEBAM", "Retcode", "HALFGLGLDLO", "ANMHKDANNDL" }, null, null, null, null)
		}));
	}
}
