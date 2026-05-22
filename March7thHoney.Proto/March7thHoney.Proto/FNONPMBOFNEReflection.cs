using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNONPMBOFNEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNONPMBOFNEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTk9OUE1CT0ZORS5wcm90byJyCgtGTk9OUE1CT0ZORRITCgtGTUlHQUVG" + "SkJPSxgBIAEoCBIRCgl1bmlxdWVfaWQYByABKA0SFAoMbW9uc3Rlcl9saXN0" + "GAogAygNEhMKC0xKS0dDTU9QSElGGA0gASgIEhAKCGFmZml4X2lkGA8gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNONPMBOFNE), FNONPMBOFNE.Parser, new string[5] { "FMIGAEFJBOK", "UniqueId", "MonsterList", "LJKGCMOPHIF", "AffixId" }, null, null, null, null)
		}));
	}
}
