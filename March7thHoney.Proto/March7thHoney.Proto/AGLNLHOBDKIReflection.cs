using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGLNLHOBDKIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGLNLHOBDKIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBR0xOTEhPQkRLSS5wcm90bypkCgtBR0xOTEhPQkRLSRIbChdBR0xOTEhP" + "QkRLSV9KT0RIT0xOTEVKShAAEhsKF0FHTE5MSE9CREtJX0FJR0NDQUhIS0JG" + "EAESGwoXQUdMTkxIT0JES0lfREJOQU9PUE1NSFAQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AGLNLHOBDKI) }, null, null));
	}
}
