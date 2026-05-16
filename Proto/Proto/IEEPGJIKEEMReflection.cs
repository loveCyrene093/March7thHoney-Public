using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IEEPGJIKEEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IEEPGJIKEEMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRUVQR0pJS0VFTS5wcm90bypkCgtJRUVQR0pJS0VFTRIbChdJRUVQR0pJ" + "S0VFTV9ETUtMRUVISlBQRBAAEhsKF0lFRVBHSklLRUVNX0RFT0hKSUxCSENH" + "EAESGwoXSUVFUEdKSUtFRU1fSFBJRUtER0VCTUcQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(IEEPGJIKEEM) }, null, null));
	}
}
