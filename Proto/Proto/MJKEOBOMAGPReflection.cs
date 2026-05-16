using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJKEOBOMAGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJKEOBOMAGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSktFT0JPTUFHUC5wcm90byIiCgtNSktFT0JPTUFHUBITCgtDSE5FS0lK" + "TUVMSxgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJKEOBOMAGP), MJKEOBOMAGP.Parser, new string[1] { "CHNEKIJMELK" }, null, null, null, null)
		}));
	}
}
