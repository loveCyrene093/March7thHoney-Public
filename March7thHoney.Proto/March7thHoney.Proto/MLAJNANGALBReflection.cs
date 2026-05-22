using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MLAJNANGALBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MLAJNANGALBReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChFNTEFKTkFOR0FMQi5wcm90bxoRQUdKUENPT01QR0gucHJvdG8aEU1PRkRB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "TkRDR0hKLnByb3RvGhFOSUxEUExKRExMSi5wcm90bxoRTk5IUEROQUNJQ0Yu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "cHJvdG8i1gEKC01MQUpOQU5HQUxCEhwKBnNvdXJjZRgKIAEoCzIMLk1PRkRB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "TkRDR0hKEiEKC0RISExJTkhLSktDGA0gASgLMgwuTk5IUEROQUNJQ0YSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "SFBFT0pOT09IREQYDiABKA0SJAoLRU9KSExQREVQUEoYtQEgASgOMgwuQUdK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "UENPT01QR0hIABIkCgtEQ0ZETUtFQkVNQxifAyABKAsyDC5OSUxEUExKRExM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "SkgAEhYKC0NES01NSEdLSkZJGPAMIAEoDUgAQg0KC0ZBQkJJR0RLQUlOQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[4]
		{
			AGJPCOOMPGHReflection.Descriptor,
			MOFDANDCGHJReflection.Descriptor,
			NILDPLJDLLJReflection.Descriptor,
			NNHPDNACICFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MLAJNANGALB), MLAJNANGALB.Parser, new string[6] { "Source", "DHHLINHKJKC", "HPEOJNOOHDD", "EOJHLPDEPPJ", "DCFDMKEBEMC", "CDKMMHGKJFI" }, new string[1] { "FABBIGDKAIN" }, null, null, null)
		}));
	}
}
