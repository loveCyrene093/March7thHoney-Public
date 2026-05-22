using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ANHLFCJGPEEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ANHLFCJGPEEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTkhMRkNKR1BFRS5wcm90byJKCgtBTkhMRkNKR1BFRRIRCglhdmF0YXJf" + "aWQYASABKA0SEwoLREtOSklLSkRIQk0YAiABKAUSEwoLZW5oYW5jZWRfaWQY" + "AyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ANHLFCJGPEE), ANHLFCJGPEE.Parser, new string[3] { "AvatarId", "DKNJIKJDHBM", "EnhancedId" }, null, null, null, null)
		}));
	}
}
