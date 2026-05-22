using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGLFACHCGCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGLFACHCGCBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFQR0xGQUNIQ0dDQi5wcm90bxoQUmVsaWNBZmZpeC5wcm90byKAAQoLUEdM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RkFDSENHQ0ISIwoOc3ViX2FmZml4X2xpc3QYAiADKAsyCy5SZWxpY0FmZml4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EhUKDW1haW5fYWZmaXhfaWQYBCABKA0SCwoDZXhwGAYgASgNEgsKA3RpZBgK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoDRIMCgR0eXBlGAsgASgNEg0KBWxldmVsGAwgASgNQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { RelicAffixReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGLFACHCGCB), PGLFACHCGCB.Parser, new string[6] { "SubAffixList", "MainAffixId", "Exp", "Tid", "Type", "Level" }, null, null, null, null)
		}));
	}
}
