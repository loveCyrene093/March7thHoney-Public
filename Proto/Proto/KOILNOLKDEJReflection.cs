using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KOILNOLKDEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KOILNOLKDEJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLT0lMTk9MS0RFSi5wcm90byJfCgtLT0lMTk9MS0RFShIPCgdjYXJkX2lk" + "GAEgASgNEhUKDWRpc3BsYXlfdmFsdWUYAiABKAESEwoLUE1ERkZKQ0lDT0kY" + "AyABKAgSEwoLc3dpdGNoX2xpc3QYBCADKAFCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KOILNOLKDEJ), KOILNOLKDEJ.Parser, new string[4] { "CardId", "DisplayValue", "PMDFFJCICOI", "SwitchList" }, null, null, null, null)
		}));
	}
}
