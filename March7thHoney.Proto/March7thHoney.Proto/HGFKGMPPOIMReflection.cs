using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HGFKGMPPOIMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HGFKGMPPOIMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIR0ZLR01QUE9JTS5wcm90byINCgtIR0ZLR01QUE9JTUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HGFKGMPPOIM), HGFKGMPPOIM.Parser, null, null, null, null, null)
		}));
	}
}
