using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidTargetInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidTargetInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRSYWlkVGFyZ2V0SW5mby5wcm90bxoRR0tIRUhDT01IQ00ucHJvdG8iXQoO" + "UmFpZFRhcmdldEluZm8SIQoLUERGTEhKTUNBSEsYASABKA4yDC5HS0hFSENP" + "TUhDTRITCgtKS0NHQ0FNSUZJQRgCIAEoDRITCgtHRkJJTUZISkFIQRgPIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GKHEHCOMHCMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RaidTargetInfo), RaidTargetInfo.Parser, new string[3] { "PDFLHJMCAHK", "JKCGCAMIFIA", "GFBIMFHJAHA" }, null, null, null, null)
		}));
	}
}
