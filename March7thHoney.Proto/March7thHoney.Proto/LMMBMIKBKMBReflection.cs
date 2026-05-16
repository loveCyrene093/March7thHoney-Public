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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFMTU1CTUlLQktNQi5wcm90bxoRQVBDTkxGQU5QRVAucHJvdG8ibgoLTE1N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Qk1JS0JLTUISEQoJdW5pcXVlX2lkGAEgASgNEg4KBm5wY19pZBgCIAEoDRIL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CgNwb3MYAyABKA0SLwoZZ3JpZF9maWdodF9lcXVpcG1lbnRfbGlzdBgEIAMo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CzIMLkFQQ05MRkFOUEVQQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { APCNLFANPEPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMMBMIKBKMB), LMMBMIKBKMB.Parser, new string[4] { "UniqueId", "NpcId", "Pos", "GridFightEquipmentList" }, null, null, null, null)
		}));
	}
}
