using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JANNOEMCKOIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JANNOEMCKOIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQU5OT0VNQ0tPSS5wcm90bxobU3Ryb25nQ2hhbGxlbmdlQXZhdGFyLnBy" + "b3RvIk0KC0pBTk5PRU1DS09JEhEKCWJ1ZmZfbGlzdBgBIAMoDRIrCgthdmF0" + "YXJfbGlzdBgOIAMoCzIWLlN0cm9uZ0NoYWxsZW5nZUF2YXRhckIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { StrongChallengeAvatarReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JANNOEMCKOI), JANNOEMCKOI.Parser, new string[2] { "BuffList", "AvatarList" }, null, null, null, null)
		}));
	}
}
