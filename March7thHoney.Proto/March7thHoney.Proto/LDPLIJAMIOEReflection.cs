using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LDPLIJAMIOEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LDPLIJAMIOEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFMRFBMSUpBTUlPRS5wcm90bxoRQUdCTExGR09CS0UucHJvdG8aEU9CTkpL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Qk1FQU9MLnByb3RvInsKC0xEUExJSkFNSU9FEiEKC0RDTEFLQ0ZKQ1BKGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "AygLMgwuT0JOSktCTUVBT0wSEQoJdW5pcXVlX2lkGAUgASgFEhMKC0RNSExM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "S0JNSEVMGA0gASgNEiEKC0VKQ0VJT01JT09QGA8gASgLMgwuQUdCTExGR09C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "S0VCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			AGBLLFGOBKEReflection.Descriptor,
			OBNJKBMEAOLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LDPLIJAMIOE), LDPLIJAMIOE.Parser, new string[4] { "DCLAKCFJCPJ", "UniqueId", "DMHLLKBMHEL", "EJCEIOMIOOP" }, null, null, null, null)
		}));
	}
}
