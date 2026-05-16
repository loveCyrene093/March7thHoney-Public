using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJEDAOPDIPMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJEDAOPDIPMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNSkVEQU9QRElQTS5wcm90bxoRTU9HRE1HSUNJS0kucHJvdG8ibQoLTUpF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "REFPUERJUE0SEQoJYXZhdGFyX2lkGAEgASgNEiEKC0JLS0RISEVETEFKGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "AygLMgwuTU9HRE1HSUNJS0kSEwoLUENMSExOQ0pQSEwYAyABKA0SEwoLRUpL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "UENGRVBBRUMYBCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { MOGDMGICIKIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJEDAOPDIPM), MJEDAOPDIPM.Parser, new string[4] { "AvatarId", "BKKDHHEDLAJ", "PCLHLNCJPHL", "EJKPCFEPAEC" }, null, null, null, null)
		}));
	}
}
