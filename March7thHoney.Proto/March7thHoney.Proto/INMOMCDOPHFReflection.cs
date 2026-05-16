using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class INMOMCDOPHFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static INMOMCDOPHFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTk1PTUNET1BIRi5wcm90byJHCgtJTk1PTUNET1BIRhITCgtJQk5FTEFK" + "Sk9BTxgBIAEoDRIOCgZkYW1hZ2UYAiABKAESEwoLSUhLRUpPRUhJS0sYAyAB" + "KAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(INMOMCDOPHF), INMOMCDOPHF.Parser, new string[3] { "IBNELAJJOAO", "Damage", "IHKEJOEHIKK" }, null, null, null, null)
		}));
	}
}
