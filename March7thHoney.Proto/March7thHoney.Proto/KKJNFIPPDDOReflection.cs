using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KKJNFIPPDDOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KKJNFIPPDDOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLS0pORklQUERETy5wcm90byJZCgtLS0pORklQUERETxIRCgl1bmlxdWVf" + "aWQYBSABKA0SEwoLS0xPT0ZBRUpHS0QYCSABKA0SEwoLQk9GT01BUEtLSE0Y" + "CyADKA0SDQoFbGV2ZWwYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KKJNFIPPDDO), KKJNFIPPDDO.Parser, new string[4] { "UniqueId", "KLOOFAEJGKD", "BOFOMAPKKHM", "Level" }, null, null, null, null)
		}));
	}
}
