using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AHPCJPMMEMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AHPCJPMMEMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSFBDSlBNTUVNTi5wcm90byIsCgtBSFBDSlBNTUVNThIPCgdpdGVtX2lk" + "GAYgASgNEgwKBHNsb3QYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AHPCJPMMEMN), AHPCJPMMEMN.Parser, new string[2] { "ItemId", "Slot" }, null, null, null, null)
		}));
	}
}
