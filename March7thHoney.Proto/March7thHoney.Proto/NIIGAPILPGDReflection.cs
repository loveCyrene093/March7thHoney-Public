using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NIIGAPILPGDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NIIGAPILPGDReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFOSUlHQVBJTFBHRC5wcm90bxoSUGxhdGZvcm1UeXBlLnByb3RvItYBCgtO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "SUlHQVBJTFBHRBILCgN1aWQYASABKA0SDQoFbGV2ZWwYAiABKA0SEAoIbmlj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "a25hbWUYAyABKAkSEwoLSkhISE9OSklLR0wYBCABKA0SHwoIcGxhdGZvcm0Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "BSABKA4yDS5QbGF0Zm9ybVR5cGUSEwoLSEJJRENBRk9QTUcYBiABKAkSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "SUtJS01FRUpORE4YByABKAkSDwoHdmVyc2lvbhgIIAEoBBITCgtHSUtBQkVN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "Q0ZBTxgJIAEoCBITCgtDTEROR0FFSUJERhgKIAEoDUIWqgITTWFyY2g3dGhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { PlatformTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NIIGAPILPGD), NIIGAPILPGD.Parser, new string[10] { "Uid", "Level", "Nickname", "JHHHONJIKGL", "Platform", "HBIDCAFOPMG", "IKIKMEEJNDN", "Version", "GIKABEMCFAO", "CLDNGAEIBDF" }, null, null, null, null)
		}));
	}
}
