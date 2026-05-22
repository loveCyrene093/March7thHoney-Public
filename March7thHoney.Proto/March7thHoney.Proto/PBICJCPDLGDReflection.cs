using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBICJCPDLGDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBICJCPDLGDReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFQQklDSkNQRExHRC5wcm90bxoRREZMREFDT0lIS0oucHJvdG8aEUlETlBJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SEZPT0FMLnByb3RvGhFOREJEREVBUElEUC5wcm90byKYAQoLUEJJQ0pDUERM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "R0QSLgoVbG9iYnlfZ3JpZF9maWdodF9pbmZvGOkHIAEoCzIMLkRGTERBQ09J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "SEtKSAASJAoLUENGTkpKQ09KRUQY6gcgASgLMgwuSUROUElIRk9PQUxIABIk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "CgtMS0lDSEZQQ09CTxjrByABKAsyDC5OREJEREVBUElEUEgAQg0KC0JHTURL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "TE9CSUNNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			DFLDACOIHKJReflection.Descriptor,
			IDNPIHFOOALReflection.Descriptor,
			NDBDDEAPIDPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PBICJCPDLGD), PBICJCPDLGD.Parser, new string[3] { "LobbyGridFightInfo", "PCFNJJCOJED", "LKICHFPCOBO" }, new string[1] { "BGMDKLOBICM" }, null, null, null)
		}));
	}
}
