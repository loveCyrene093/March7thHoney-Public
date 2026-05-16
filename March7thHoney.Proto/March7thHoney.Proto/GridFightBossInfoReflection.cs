using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightBossInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightBossInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHcmlkRmlnaHRCb3NzSW5mby5wcm90bxoRUEpMQkRNUEVLRlAucHJvdG8i" + "NgoRR3JpZEZpZ2h0Qm9zc0luZm8SIQoLSUpPUEJQQUJQUE0YBiADKAsyDC5Q" + "SkxCRE1QRUtGUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PJLBDMPEKFPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightBossInfo), GridFightBossInfo.Parser, new string[1] { "IJOPBPABPPM" }, null, null, null, null)
		}));
	}
}
