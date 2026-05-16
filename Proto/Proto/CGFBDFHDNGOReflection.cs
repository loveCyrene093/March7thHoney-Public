using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CGFBDFHDNGOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CGFBDFHDNGOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDR0ZCREZIRE5HTy5wcm90byJECgtDR0ZCREZIRE5HTxITCgtBRlBFTEZN" + "UElDSRgCIAEoDRITCgtMS01HTkNCT09LRBgFIAEoDRILCgN1aWQYDSABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CGFBDFHDNGO), CGFBDFHDNGO.Parser, new string[3] { "AFPELFMPICI", "LKMGNCBOOKD", "Uid" }, null, null, null, null)
		}));
	}
}
