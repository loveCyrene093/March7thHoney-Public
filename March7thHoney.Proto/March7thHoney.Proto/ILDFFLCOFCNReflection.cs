using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ILDFFLCOFCNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ILDFFLCOFCNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTERGRkxDT0ZDTi5wcm90byI1CgtJTERGRkxDT0ZDThITCgthdmF0YXJf" + "dHlwZRgBIAEoDRIRCglhdmF0YXJfaWQYDiABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ILDFFLCOFCN), ILDFFLCOFCN.Parser, new string[2] { "AvatarType", "AvatarId" }, null, null, null, null)
		}));
	}
}
