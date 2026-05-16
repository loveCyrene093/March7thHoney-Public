using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LDHOKGLFPKFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LDHOKGLFPKFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMREhPS0dMRlBLRi5wcm90byIcCgtMREhPS0dMRlBLRhINCgVjb3VudBgB" + "IAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LDHOKGLFPKF), LDHOKGLFPKF.Parser, new string[1] { "Count" }, null, null, null, null)
		}));
	}
}
