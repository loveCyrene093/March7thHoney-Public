using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EFBIMNFGMBMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EFBIMNFGMBMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRkJJTU5GR01CTS5wcm90byJKCgtFRkJJTU5GR01CTRITCgtBRkFIREJQ" + "R0pMTBgCIAEoDRIRCglhdmF0YXJfaWQYCSABKA0SEwoLTE5OTkNFSUxDQUEY" + "CyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EFBIMNFGMBM), EFBIMNFGMBM.Parser, new string[3] { "AFAHDBPGJLL", "AvatarId", "LNNNCEILCAA" }, null, null, null, null)
		}));
	}
}
