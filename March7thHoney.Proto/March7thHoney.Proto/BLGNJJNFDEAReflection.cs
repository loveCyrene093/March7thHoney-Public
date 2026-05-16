using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BLGNJJNFDEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BLGNJJNFDEAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTEdOSkpORkRFQS5wcm90byIyCgtCTEdOSkpORkRFQRIQCghncm91cF9p" + "ZBgDIAEoDRIRCgljb25maWdfaWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BLGNJJNFDEA), BLGNJJNFDEA.Parser, new string[2] { "GroupId", "ConfigId" }, null, null, null, null)
		}));
	}
}
