using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DMAJILEBABMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DMAJILEBABMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETUFKSUxFQkFCTS5wcm90bxoRRFBFSElMQUFOT04ucHJvdG8aEUlKT0tE" + "TE1LREFFLnByb3RvIlMKC0RNQUpJTEVCQUJNEiEKC0tDRUZOSU1BRUpQGAMg" + "AygLMgwuRFBFSElMQUFOT04SIQoLSkpHTVBGR0NLSEcYCyADKAsyDC5JSk9L" + "RExNS0RBRUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			DPEHILAANONReflection.Descriptor,
			IJOKDLMKDAEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DMAJILEBABM), DMAJILEBABM.Parser, new string[2] { "KCEFNIMAEJP", "JJGMPFGCKHG" }, null, null, null, null)
		}));
	}
}
