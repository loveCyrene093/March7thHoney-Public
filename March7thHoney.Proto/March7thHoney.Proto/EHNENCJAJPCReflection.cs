using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EHNENCJAJPCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EHNENCJAJPCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSE5FTkNKQUpQQy5wcm90byJKCgtFSE5FTkNKQUpQQxIVCgtGSERKRkFN" + "TU5PRhgLIAEoDUgAEhUKC0NHT0FCR0tDQkVGGA4gASgNSABCDQoLRkZHSUVG" + "Tk9MSE5CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EHNENCJAJPC), EHNENCJAJPC.Parser, new string[2] { "FHDJFAMMNOF", "CGOABGKCBEF" }, new string[1] { "FFGIEFNOLHN" }, null, null, null)
		}));
	}
}
