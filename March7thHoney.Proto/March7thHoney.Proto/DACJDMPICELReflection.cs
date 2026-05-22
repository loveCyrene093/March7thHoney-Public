using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DACJDMPICELReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DACJDMPICELReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQUNKRE1QSUNFTC5wcm90byJECgtEQUNKRE1QSUNFTBIOCgZkYW1hZ2UY" + "ASABKAESEAoIdHJhaXRfaWQYBCABKA0SEwoLTktGREJFSFBOTEcYDyABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DACJDMPICEL), DACJDMPICEL.Parser, new string[3] { "Damage", "TraitId", "NKFDBEHPNLG" }, null, null, null, null)
		}));
	}
}
