using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IKEBEPBJHCEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IKEBEPBJHCEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJS0VCRVBCSkhDRS5wcm90byINCgtJS0VCRVBCSkhDRUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IKEBEPBJHCE), IKEBEPBJHCE.Parser, null, null, null, null, null)
		}));
	}
}
