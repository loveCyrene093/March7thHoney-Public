using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BLKAIEHOCBCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BLKAIEHOCBCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTEtBSUVIT0NCQy5wcm90byI+CgtCTEtBSUVIT0NCQxINCgVsZXZlbBgG" + "IAEoDRITCgtES0hLRUpJQUpCThgMIAEoDRILCgNleHAYDyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BLKAIEHOCBC), BLKAIEHOCBC.Parser, new string[3] { "Level", "DKHKEJIAJBN", "Exp" }, null, null, null, null)
		}));
	}
}
