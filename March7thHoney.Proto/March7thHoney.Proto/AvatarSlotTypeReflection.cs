using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarSlotTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarSlotTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRBdmF0YXJTbG90VHlwZS5wcm90bypJCg5BdmF0YXJTbG90VHlwZRIRCg1B" + "VkFUQVJfU0xPVF8xEAASEQoNQVZBVEFSX1NMT1RfMhABEhEKDUFWQVRBUl9T" + "TE9UXzMQAkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AvatarSlotType) }, null, null));
	}
}
