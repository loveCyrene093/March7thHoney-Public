using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DifficultyAdjustmentTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DifficultyAdjustmentTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5EaWZmaWN1bHR5QWRqdXN0bWVudFR5cGUucHJvdG8qVAoYRGlmZmljdWx0" + "eUFkanVzdG1lbnRUeXBlEhsKF05KQUFFT0ZJQ01MX0NHS0VJQUlQQUVLEAAS" + "GwoXTkpBQUVPRklDTUxfQVBIQ0FDUEpNT0YQAUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DifficultyAdjustmentType) }, null, null));
	}
}
