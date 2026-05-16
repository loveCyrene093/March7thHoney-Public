using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGJPCOOMPGHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGJPCOOMPGHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBR0pQQ09PTVBHSC5wcm90bypkCgtBR0pQQ09PTVBHSBIbChdBR0pQQ09P" + "TVBHSF9QQ1BESEVMUEtFTRAAEhsKF0FHSlBDT09NUEdIX09DS0VKTUZNTkFB" + "EAESGwoXQUdKUENPT01QR0hfTkFKQ1BPUEpHTEIQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AGJPCOOMPGH) }, null, null));
	}
}
