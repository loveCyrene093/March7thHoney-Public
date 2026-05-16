using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DENBKAOHBAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DENBKAOHBAMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERU5CS0FPSEJBTS5wcm90byI3CgtERU5CS0FPSEJBTRITCgtNRk9NTUZI" + "UEpESRgBIAEoDRITCgtESkxDS0ZLR01ETBgCIAEoAUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DENBKAOHBAM), DENBKAOHBAM.Parser, new string[2] { "MFOMMFHPJDI", "DJLCKFKGMDL" }, null, null, null, null)
		}));
	}
}
