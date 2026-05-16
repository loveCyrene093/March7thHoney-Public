using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GrowthTartgetFuncTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GrowthTartgetFuncTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHcm93dGhUYXJ0Z2V0RnVuY1R5cGUucHJvdG8qZQoVR3Jvd3RoVGFydGdl" + "dEZ1bmNUeXBlEiUKIUdyb3d0aFRhcnRnZXRGdW5jVHlwZV9JSVBJQUtKRkdO" + "SBAAEiUKIUdyb3d0aFRhcnRnZXRGdW5jVHlwZV9LRElOSkpFR01IQhABQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GrowthTartgetFuncType) }, null, null));
	}
}
