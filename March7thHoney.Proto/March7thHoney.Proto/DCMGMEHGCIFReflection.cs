using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCMGMEHGCIFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCMGMEHGCIFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQ01HTUVIR0NJRi5wcm90bypkCgtEQ01HTUVIR0NJRhIbChdEQ01HTUVI" + "R0NJRl9LSkZITFBFT05PSBAAEhsKF0RDTUdNRUhHQ0lGX09OQUNITUVEUElL" + "EAESGwoXRENNR01FSEdDSUZfS0FMREtMUEhHRUoQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DCMGMEHGCIF) }, null, null));
	}
}
