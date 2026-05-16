using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ItemTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ItemTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5JdGVtVHlwZS5wcm90byqAAQoISXRlbVR5cGUSEgoOSVRFTV9UWVBFX05P" + "TkUQABIUChBJVEVNX0FWQVRBUl9DQVJEEAESEgoOSVRFTV9FUVVJUE1FTlQQ" + "AhIRCg1JVEVNX01BVEVSSUFMEAMSEwoPSVRFTV9BVkFUQVJfRVhQEAQSDgoK" + "SVRFTV9SRUxJQxAFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ItemType) }, null, null));
	}
}
