using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEBBEGGFJMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEBBEGGFJMIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRUJCRUdHRkpNSS5wcm90byIxCgtNRUJCRUdHRkpNSRINCgV0aXRsZRgB" + "IAEoCRITCgtOTEdLTU5MRURHRBgCIAEoCUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEBBEGGFJMI), MEBBEGGFJMI.Parser, new string[2] { "Title", "NLGKMNLEDGD" }, null, null, null, null)
		}));
	}
}
