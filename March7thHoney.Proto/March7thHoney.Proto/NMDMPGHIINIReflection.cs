using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NMDMPGHIINIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NMDMPGHIINIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTURNUEdISUlOSS5wcm90byJMCgtOTURNUEdISUlOSRITCgtJTElQR0FF" + "Q1BQQxgDIAEoDRITCgtJQ0RGRE9LRkxBSxgIIAEoDRITCgtBTU9PUENMR0tH" + "RBgKIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NMDMPGHIINI), NMDMPGHIINI.Parser, new string[3] { "ILIPGAECPPC", "ICDFDOKFLAK", "AMOOPCLGKGD" }, null, null, null, null)
		}));
	}
}
