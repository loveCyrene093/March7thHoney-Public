using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IMPEJAJCHPCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IMPEJAJCHPCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTVBFSkFKQ0hQQy5wcm90byJGCgtJTVBFSkFKQ0hQQxISCgphdWdtZW50" + "X2lkGAEgASgNEg4KBmRhbWFnZRgDIAEoARITCgtCT0lFR1BBUEhPUBgEIAEo" + "AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IMPEJAJCHPC), IMPEJAJCHPC.Parser, new string[3] { "AugmentId", "Damage", "BOIEGPAPHOP" }, null, null, null, null)
		}));
	}
}
