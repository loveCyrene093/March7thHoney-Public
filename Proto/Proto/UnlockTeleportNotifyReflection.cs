using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockTeleportNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockTeleportNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVbmxvY2tUZWxlcG9ydE5vdGlmeS5wcm90byI9ChRVbmxvY2tUZWxlcG9y" + "dE5vdGlmeRIQCghlbnRyeV9pZBgDIAEoDRITCgt0ZWxlcG9ydF9pZBgGIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTeleportNotify), UnlockTeleportNotify.Parser, new string[2] { "EntryId", "TeleportId" }, null, null, null, null)
		}));
	}
}
