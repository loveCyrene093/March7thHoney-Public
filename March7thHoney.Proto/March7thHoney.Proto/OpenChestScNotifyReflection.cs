using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenChestScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenChestScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdPcGVuQ2hlc3RTY05vdGlmeS5wcm90byIlChFPcGVuQ2hlc3RTY05vdGlm" + "eRIQCghjaGVzdF9pZBgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenChestScNotify), OpenChestScNotify.Parser, new string[1] { "ChestId" }, null, null, null, null)
		}));
	}
}
