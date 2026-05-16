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
		buffer[0] = "ChFNTEFKTkFOR0FMQi5wcm90bxoRQUdKUENPT01QR0gucHJvdG8aEU1PRkRB";
		buffer[1] = "TkRDR0hKLnByb3RvGhFOSUxEUExKRExMSi5wcm90bxoRTk5IUEROQUNJQ0Yu";
		buffer[2] = "cHJvdG8i1gEKC01MQUpOQU5HQUxCEhwKBnNvdXJjZRgKIAEoCzIMLk1PRkRB";
		buffer[3] = "TkRDR0hKEiEKC0RISExJTkhLSktDGA0gASgLMgwuTk5IUEROQUNJQ0YSEwoL";
		buffer[4] = "SFBFT0pOT09IREQYDiABKA0SJAoLRU9KSExQREVQUEoYtQEgASgOMgwuQUdK";
		buffer[5] = "UENPT01QR0hIABIkCgtEQ0ZETUtFQkVNQxifAyABKAsyDC5OSUxEUExKRExM";
		buffer[6] = "SkgAEhYKC0NES01NSEdLSkZJGPAMIAEoDUgAQg0KC0ZBQkJJR0RLQUlOQhaq";
		buffer[7] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
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
