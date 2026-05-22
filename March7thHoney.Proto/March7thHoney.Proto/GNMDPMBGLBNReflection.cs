using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GNMDPMBGLBNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GNMDPMBGLBNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTk1EUE1CR0xCTi5wcm90bypkCgtHTk1EUE1CR0xCThIbChdHTk1EUE1C" + "R0xCTl9BSERBTE1IRURNUBAAEhsKF0dOTURQTUJHTEJOX0JORExFR0JDQ01E" + "EAESGwoXR05NRFBNQkdMQk5fS0pPTkxFS0pGREwQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GNMDPMBGLBN) }, null, null));
	}
}
