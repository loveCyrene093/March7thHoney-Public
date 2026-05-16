using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class VirtualLineupDestroyNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static VirtualLineupDestroyNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBWaXJ0dWFsTGluZXVwRGVzdHJveU5vdGlmeS5wcm90byIuChpWaXJ0dWFs" + "TGluZXVwRGVzdHJveU5vdGlmeRIQCghwbGFuZV9pZBgNIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(VirtualLineupDestroyNotify), VirtualLineupDestroyNotify.Parser, new string[1] { "PlaneId" }, null, null, null, null)
		}));
	}
}
