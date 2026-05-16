using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ACDGMLBDJJNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ACDGMLBDJJNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQ0RHTUxCREpKTi5wcm90byJgCgtBQ0RHTUxCREpKThITCgtCTkxISU1I" + "RkdESxgCIAEoDRITCgtGRU1QQ0dDQkhLQhgDIAEoDRISCgpzZWN0aW9uX2lk" + "GAggASgNEhMKC0RDUEtQTkxLR01NGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ACDGMLBDJJN), ACDGMLBDJJN.Parser, new string[4] { "BNLHIMHFGDK", "FEMPCGCBHKB", "SectionId", "DCPKPNLKGMM" }, null, null, null, null)
		}));
	}
}
