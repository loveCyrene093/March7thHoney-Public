using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PDPALPDALDGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PDPALPDALDGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRFBBTFBEQUxERy5wcm90byIvCgtQRFBBTFBEQUxERxILCgN1aWQYASAB" + "KA0SEwoLSUdHS0tEUEpEQkUYBSADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PDPALPDALDG), PDPALPDALDG.Parser, new string[2] { "Uid", "IGGKKDPJDBE" }, null, null, null, null)
		}));
	}
}
