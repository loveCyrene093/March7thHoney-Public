using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NGLKDCCLFGBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NGLKDCCLFGBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOR0xLRENDTEZHQi5wcm90bxoRQkJQQ0NIR0pDUEYucHJvdG8iMAoLTkdM" + "S0RDQ0xGR0ISIQoLR01QRUJCSEZMSEkYASABKAsyDC5CQlBDQ0hHSkNQRkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BBPCCHGJCPFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NGLKDCCLFGB), NGLKDCCLFGB.Parser, new string[1] { "GMPEBBHFLHI" }, null, null, null, null)
		}));
	}
}
