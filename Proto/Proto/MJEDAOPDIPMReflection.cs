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
		buffer[0] = "ChFNSkVEQU9QRElQTS5wcm90bxoRTU9HRE1HSUNJS0kucHJvdG8ibQoLTUpF";
		buffer[1] = "REFPUERJUE0SEQoJYXZhdGFyX2lkGAEgASgNEiEKC0JLS0RISEVETEFKGAIg";
		buffer[2] = "AygLMgwuTU9HRE1HSUNJS0kSEwoLUENMSExOQ0pQSEwYAyABKA0SEwoLRUpL";
		buffer[3] = "UENGRVBBRUMYBCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MOGDMGICIKIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJEDAOPDIPM), MJEDAOPDIPM.Parser, new string[4] { "AvatarId", "BKKDHHEDLAJ", "PCLHLNCJPHL", "EJKPCFEPAEC" }, null, null, null, null)
		}));
	}
}
