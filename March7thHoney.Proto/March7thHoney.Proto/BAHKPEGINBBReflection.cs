using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAHKPEGINBBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAHKPEGINBBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQUhLUEVHSU5CQi5wcm90byIxCgtCQUhLUEVHSU5CQhINCgVsZXZlbBgE" + "IAEoDRITCgtKTkdITU9QRUtKTxgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAHKPEGINBB), BAHKPEGINBB.Parser, new string[2] { "Level", "JNGHMOPEKJO" }, null, null, null, null)
		}));
	}
}
