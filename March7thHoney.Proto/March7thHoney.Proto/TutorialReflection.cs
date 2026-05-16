using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TutorialReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TutorialReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5UdXRvcmlhbC5wcm90bxoUVHV0b3JpYWxTdGF0dXMucHJvdG8iNwoIVHV0" + "b3JpYWwSHwoGc3RhdHVzGAIgASgOMg8uVHV0b3JpYWxTdGF0dXMSCgoCaWQY" + "AyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { TutorialStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Tutorial), Tutorial.Parser, new string[2] { "Status", "Id" }, null, null, null, null)
		}));
	}
}
