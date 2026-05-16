using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AABFLGKCHCAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AABFLGKCHCAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQUJGTEdLQ0hDQS5wcm90byJ0CgtBQUJGTEdLQ0hDQRIhChlpbnRlcmFj" + "dGVkX3Byb3BfZW50aXR5X2lkGAIgASgNEhsKE2Jhc2VfYXZhdGFyX2lkX2xp" + "c3QYByADKA0SJQoddW5maW5pc2hlZF9zdG9yeV9saW5lX2lkX2xpc3QYDyAD" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AABFLGKCHCA), AABFLGKCHCA.Parser, new string[3] { "InteractedPropEntityId", "BaseAvatarIdList", "UnfinishedStoryLineIdList" }, null, null, null, null)
		}));
	}
}
