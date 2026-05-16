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
		buffer[0] = "ChFQR0xGQUNIQ0dDQi5wcm90bxoQUmVsaWNBZmZpeC5wcm90byKAAQoLUEdM";
		buffer[1] = "RkFDSENHQ0ISIwoOc3ViX2FmZml4X2xpc3QYAiADKAsyCy5SZWxpY0FmZml4";
		buffer[2] = "EhUKDW1haW5fYWZmaXhfaWQYBCABKA0SCwoDZXhwGAYgASgNEgsKA3RpZBgK";
		buffer[3] = "IAEoDRIMCgR0eXBlGAsgASgNEg0KBWxldmVsGAwgASgNQhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicAffixReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGLFACHCGCB), PGLFACHCGCB.Parser, new string[6] { "SubAffixList", "MainAffixId", "Exp", "Tid", "Type", "Level" }, null, null, null, null)
		}));
	}
}
