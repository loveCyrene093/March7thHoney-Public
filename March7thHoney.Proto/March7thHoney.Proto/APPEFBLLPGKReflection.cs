using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APPEFBLLPGKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APPEFBLLPGKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUFBFRkJMTFBHSy5wcm90byIgCgtBUFBFRkJMTFBHSxIRCgljdXJfaW5k" + "ZXgYBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APPEFBLLPGK), APPEFBLLPGK.Parser, new string[1] { "CurIndex" }, null, null, null, null)
		}));
	}
}
