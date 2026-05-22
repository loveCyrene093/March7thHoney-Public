using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncChangeNtfReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncChangeNtfReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTeW5jQ2hhbmdlTnRmLnByb3RvGhFGQUlHSElQREtJRy5wcm90byIyCg1T" + "eW5jQ2hhbmdlTnRmEiEKC0NKRkJMSE5QSEFLGAkgAygLMgwuRkFJR0hJUERL" + "SUdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { FAIGHIPDKIGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncChangeNtf), SyncChangeNtf.Parser, new string[1] { "CJFBLHNPHAK" }, null, null, null, null)
		}));
	}
}
