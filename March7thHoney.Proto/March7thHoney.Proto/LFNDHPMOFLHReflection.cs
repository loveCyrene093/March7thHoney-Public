using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LFNDHPMOFLHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LFNDHPMOFLHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMRk5ESFBNT0ZMSC5wcm90byI3CgtMRk5ESFBNT0ZMSBITCgtESExES0xN" + "UEhORxgKIAEoDRITCgtMTUlJQ0VOTU9CSRgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LFNDHPMOFLH), LFNDHPMOFLH.Parser, new string[2] { "DHLDKLMPHNG", "LMIICENMOBI" }, null, null, null, null)
		}));
	}
}
