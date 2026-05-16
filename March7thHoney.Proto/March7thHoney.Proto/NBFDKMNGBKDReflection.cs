using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBFDKMNGBKDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBFDKMNGBKDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQkZES01OR0JLRC5wcm90byJKCgtOQkZES01OR0JLRBITCgtEQUNPS0ZD" + "Qk1CSRgFIAEoDRIRCgl1bmlxdWVfaWQYDCABKA0SEwoLTExFRUZER0pCS0EY" + "DSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBFDKMNGBKD), NBFDKMNGBKD.Parser, new string[3] { "DACOKFCBMBI", "UniqueId", "LLEEFDGJBKA" }, null, null, null, null)
		}));
	}
}
