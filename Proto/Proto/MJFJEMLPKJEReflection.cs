using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJFJEMLPKJEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJFJEMLPKJEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNSkZKRU1MUEtKRS5wcm90bxoQUmVsaWNBZmZpeC5wcm90byJyCgtNSkZK";
		buffer[1] = "RU1MUEtKRRINCgVsZXZlbBgBIAEoDRILCgNleHAYAyABKA0SFQoNbWFpbl9h";
		buffer[2] = "ZmZpeF9pZBgHIAEoDRILCgN0aWQYDSABKA0SIwoOc3ViX2FmZml4X2xpc3QY";
		buffer[3] = "DyADKAsyCy5SZWxpY0FmZml4QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[4] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicAffixReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJFJEMLPKJE), MJFJEMLPKJE.Parser, new string[5] { "Level", "Exp", "MainAffixId", "Tid", "SubAffixList" }, null, null, null, null)
		}));
	}
}
