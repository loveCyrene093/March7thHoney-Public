using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMMBMIKBKMBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMMBMIKBKMBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMTU1CTUlLQktNQi5wcm90bxoRQVBDTkxGQU5QRVAucHJvdG8ibgoLTE1N";
		buffer[1] = "Qk1JS0JLTUISEQoJdW5pcXVlX2lkGAEgASgNEg4KBm5wY19pZBgCIAEoDRIL";
		buffer[2] = "CgNwb3MYAyABKA0SLwoZZ3JpZF9maWdodF9lcXVpcG1lbnRfbGlzdBgEIAMo";
		buffer[3] = "CzIMLkFQQ05MRkFOUEVQQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[4] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { APCNLFANPEPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMMBMIKBKMB), LMMBMIKBKMB.Parser, new string[4] { "UniqueId", "NpcId", "Pos", "GridFightEquipmentList" }, null, null, null, null)
		}));
	}
}
