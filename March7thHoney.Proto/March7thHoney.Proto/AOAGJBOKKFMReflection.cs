using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AOAGJBOKKFMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AOAGJBOKKFMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBT0FHSkJPS0tGTS5wcm90byIgCgtBT0FHSkJPS0tGTRIRCgl1bmlxdWVf" + "aWQYASABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AOAGJBOKKFM), AOAGJBOKKFM.Parser, new string[1] { "UniqueId" }, null, null, null, null)
		}));
	}
}
