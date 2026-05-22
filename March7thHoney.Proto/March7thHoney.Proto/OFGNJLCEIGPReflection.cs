using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFGNJLCEIGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFGNJLCEIGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRkdOSkxDRUlHUC5wcm90byINCgtPRkdOSkxDRUlHUEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFGNJLCEIGP), OFGNJLCEIGP.Parser, null, null, null, null, null)
		}));
	}
}
