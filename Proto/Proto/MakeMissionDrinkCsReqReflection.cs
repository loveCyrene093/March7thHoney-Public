using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MakeMissionDrinkCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MakeMissionDrinkCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNYWtlTWlzc2lvbkRyaW5rQ3NSZXEucHJvdG8aEUNJR0tCRElHR09JLnBy" + "b3RvImAKFU1ha2VNaXNzaW9uRHJpbmtDc1JlcRITCgtKQUNDSkdCR0pPQRgB" + "IAEoDRIhCgtJSERNTEhGQUVLSBgLIAEoCzIMLkNJR0tCRElHR09JEg8KB2lz" + "X3NhdmUYDiABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { CIGKBDIGGOIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MakeMissionDrinkCsReq), MakeMissionDrinkCsReq.Parser, new string[3] { "JACCJGBGJOA", "IHDMLHFAEKH", "IsSave" }, null, null, null, null)
		}));
	}
}
