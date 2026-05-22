using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPDDLAOBMBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPDDLAOBMBHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFEUERETEFPQk1CSC5wcm90bxoRRU5BS0ROQ0VKQk8ucHJvdG8aH1JlbGlj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "UHJlc2V0UGxhblNvdXJjZVR5cGUucHJvdG8idAoLRFBERExBT0JNQkgSIQoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "SEJOSEtQRE1HSVAYBiABKA4yDC5FTkFLRE5DRUpCTxIvCgtBTEZITkVIT0JK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QRgNIAEoDjIaLlJlbGljUHJlc2V0UGxhblNvdXJjZVR5cGUSEQoJcmVsaWNf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aWRzGA4gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ENAKDNCEJBOReflection.Descriptor,
			RelicPresetPlanSourceTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPDDLAOBMBH), DPDDLAOBMBH.Parser, new string[3] { "HBNHKPDMGIP", "ALFHNEHOBJA", "RelicIds" }, null, null, null, null)
		}));
	}
}
