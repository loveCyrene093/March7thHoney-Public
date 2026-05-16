using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HipplenTraitUnlockScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HipplenTraitUnlockScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBIaXBwbGVuVHJhaXRVbmxvY2tTY05vdGlmeS5wcm90byI7ChpIaXBwbGVu" + "VHJhaXRVbmxvY2tTY05vdGlmeRIdChVncmlkX2ZpZ2h0X3RyYWl0X2luZm8Y" + "DSADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HipplenTraitUnlockScNotify), HipplenTraitUnlockScNotify.Parser, new string[1] { "GridFightTraitInfo" }, null, null, null, null)
		}));
	}
}
