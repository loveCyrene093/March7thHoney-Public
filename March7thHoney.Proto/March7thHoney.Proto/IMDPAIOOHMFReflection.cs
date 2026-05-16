using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IMDPAIOOHMFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IMDPAIOOHMFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFJTURQQUlPT0hNRi5wcm90bxoRQUFIQkVDSUNPRU4ucHJvdG8ioAEKC0lN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RFBBSU9PSE1GEiEKC0xDUElPRENMTkhMGAIgAygLMgwuQUFIQkVDSUNPRU4S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "EwoLQUZDQU9CRUJPTUgYBCABKA0SIQoLTEpIRE9GQkZOSkgYCiABKAsyDC5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QUhCRUNJQ09FThITCgtGUExEQUtOQUxLTBgMIAEoDRIhCgtQR0lIR05PTElP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "SRgNIAMoCzIMLkFBSEJFQ0lDT0VOQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { AAHBECICOENReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IMDPAIOOHMF), IMDPAIOOHMF.Parser, new string[5] { "LCPIODCLNHL", "AFCAOBEBOMH", "LJHDOFBFNJH", "FPLDAKNALKL", "PGIHGNOLIOI" }, null, null, null, null)
		}));
	}
}
