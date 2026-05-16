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
		buffer[0] = "ChFOSUlHQVBJTFBHRC5wcm90bxoSUGxhdGZvcm1UeXBlLnByb3RvItYBCgtO";
		buffer[1] = "SUlHQVBJTFBHRBILCgN1aWQYASABKA0SDQoFbGV2ZWwYAiABKA0SEAoIbmlj";
		buffer[2] = "a25hbWUYAyABKAkSEwoLSkhISE9OSklLR0wYBCABKA0SHwoIcGxhdGZvcm0Y";
		buffer[3] = "BSABKA4yDS5QbGF0Zm9ybVR5cGUSEwoLSEJJRENBRk9QTUcYBiABKAkSEwoL";
		buffer[4] = "SUtJS01FRUpORE4YByABKAkSDwoHdmVyc2lvbhgIIAEoBBITCgtHSUtBQkVN";
		buffer[5] = "Q0ZBTxgJIAEoCBITCgtDTEROR0FFSUJERhgKIAEoDUIWqgITTWFyY2g3dGhI";
		buffer[6] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PlatformTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NIIGAPILPGD), NIIGAPILPGD.Parser, new string[10] { "Uid", "Level", "Nickname", "JHHHONJIKGL", "Platform", "HBIDCAFOPMG", "IKIKMEEJNDN", "Version", "GIKABEMCFAO", "CLDNGAEIBDF" }, null, null, null, null)
		}));
	}
}
