using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicAffixReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicAffixReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBSZWxpY0FmZml4LnByb3RvIjkKClJlbGljQWZmaXgSEAoIYWZmaXhfaWQY" + "ASABKA0SCwoDY250GAIgASgNEgwKBHN0ZXAYAyABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicAffix), RelicAffix.Parser, new string[3] { "AffixId", "Cnt", "Step" }, null, null, null, null)
		}));
	}
}
