using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BOOCAFOIFLFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BOOCAFOIFLFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCT09DQUZPSUZMRi5wcm90bypkCgtCT09DQUZPSUZMRhIbChdCT09DQUZP" + "SUZMRl9EQVBDRk9PT0lHQRAAEhsKF0JPT0NBRk9JRkxGX09DSElGQ0JNSUxF" + "EAESGwoXQk9PQ0FGT0lGTEZfUEVBR0NCUEpQTUsQIEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BOOCAFOIFLF) }, null, null));
	}
}
