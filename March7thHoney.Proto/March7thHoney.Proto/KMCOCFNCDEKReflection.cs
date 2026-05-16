using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KMCOCFNCDEKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KMCOCFNCDEKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTUNPQ0ZOQ0RFSy5wcm90byJKCgtLTUNPQ0ZOQ0RFSxITCgtMTEVFRkRH" + "SkJLQRgCIAEoDRIRCgl1bmlxdWVfaWQYBiABKA0SEwoLSE5LTkhDRUlBSUYY" + "DiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KMCOCFNCDEK), KMCOCFNCDEK.Parser, new string[3] { "LLEEFDGJBKA", "UniqueId", "HNKNHCEIAIF" }, null, null, null, null)
		}));
	}
}
