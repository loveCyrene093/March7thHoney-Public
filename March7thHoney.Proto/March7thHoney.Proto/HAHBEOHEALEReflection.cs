using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HAHBEOHEALEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HAHBEOHEALEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQUhCRU9IRUFMRS5wcm90byI0CgtIQUhCRU9IRUFMRRIWCg5xdWV1ZV9w" + "b3NpdGlvbhgCIAEoDRINCgVsZXZlbBgDIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HAHBEOHEALE), HAHBEOHEALE.Parser, new string[2] { "QueuePosition", "Level" }, null, null, null, null)
		}));
	}
}
