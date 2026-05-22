using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IEDEMFKBHFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IEDEMFKBHFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRURFTUZLQkhGTC5wcm90bxoRQUtDTkJPRU9BUEEucHJvdG8iWgoLSUVE" + "RU1GS0JIRkwSIQoLSEpGQkFBSERIQkgYDSADKAsyDC5BS0NOQk9FT0FQQRIT" + "CgtJQVBGSklORk5MTxgOIAEoDRITCgtIRkVBUEhLSkRKUBgPIAEoCEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AKCNBOEOAPAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IEDEMFKBHFL), IEDEMFKBHFL.Parser, new string[3] { "HJFBAAHDHBH", "IAPFJINFNLO", "HFEAPHKJDJP" }, null, null, null, null)
		}));
	}
}
