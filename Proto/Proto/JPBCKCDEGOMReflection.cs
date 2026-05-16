using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JPBCKCDEGOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JPBCKCDEGOMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKUEJDS0NERUdPTS5wcm90bxoRRUxFT0dBQkdCS0cucHJvdG8iMAoLSlBC" + "Q0tDREVHT00SIQoLQUxJRERMQkRQREgYCyADKAsyDC5FTEVPR0FCR0JLR0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ELEOGABGBKGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JPBCKCDEGOM), JPBCKCDEGOM.Parser, new string[1] { "ALIDDLBDPDH" }, null, null, null, null)
		}));
	}
}
