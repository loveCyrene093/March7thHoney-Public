using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ELAGCLMOFFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ELAGCLMOFFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTEFHQ0xNT0ZGSS5wcm90byJGCgtFTEFHQ0xNT0ZGSRIOCgZkYW1hZ2UY" + "CCABKAESEgoKYXVnbWVudF9pZBgLIAEoDRITCgtCT0lFR1BBUEhPUBgNIAEo" + "AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ELAGCLMOFFI), ELAGCLMOFFI.Parser, new string[3] { "Damage", "AugmentId", "BOIEGPAPHOP" }, null, null, null, null)
		}));
	}
}
