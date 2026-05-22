using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FAJGLOFICEIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FAJGLOFICEIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQUpHTE9GSUNFSS5wcm90byJgCgtGQUpHTE9GSUNFSRITCgtORkRBSkhK" + "REdPShgFIAEoDRITCgtKTUlFTkJCTVBBRxgKIAEoDRISCgpjb250ZW50X2lk" + "GAsgASgNEhMKC0FOQkJQUEhCQ0pIGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FAJGLOFICEI), FAJGLOFICEI.Parser, new string[4] { "NFDAJHJDGOJ", "JMIENBBMPAG", "ContentId", "ANBBPPHBCJH" }, null, null, null, null)
		}));
	}
}
