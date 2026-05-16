using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NPGGDOLMNIEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NPGGDOLMNIEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOUEdHRE9MTU5JRS5wcm90bxoRUEJPRklCTEJQR0oucHJvdG8icAoLTlBH";
		buffer[1] = "R0RPTE1OSUUSEwoLSkFOREJCR0xKRU8YASABKA0SEwoLSEVJTEtCSkNBR0IY";
		buffer[2] = "AiABKA0SFAoMY2hhbGxlbmdlX2lkGA0gASgNEiEKC05ISUNNRU1KRk5JGA4g";
		buffer[3] = "ASgOMgwuUEJPRklCTEJQR0pCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PBOFIBLBPGJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NPGGDOLMNIE), NPGGDOLMNIE.Parser, new string[4] { "JANDBBGLJEO", "HEILKBJCAGB", "ChallengeId", "NHICMEMJFNI" }, null, null, null, null)
		}));
	}
}
