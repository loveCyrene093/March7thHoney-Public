using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FBBMDFDOEEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FBBMDFDOEEFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQkJNREZET0VFRi5wcm90byIyCgtGQkJNREZET0VFRhIPCgdpdGVtX2lk" + "GAEgASgNEhIKCml0ZW1fY291bnQYBiABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FBBMDFDOEEF), FBBMDFDOEEF.Parser, new string[2] { "ItemId", "ItemCount" }, null, null, null, null)
		}));
	}
}
