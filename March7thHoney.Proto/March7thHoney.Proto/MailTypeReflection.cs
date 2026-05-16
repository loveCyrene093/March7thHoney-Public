using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MailTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MailTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5NYWlsVHlwZS5wcm90byo0CghNYWlsVHlwZRIUChBNQUlMX1RZUEVfTk9S" + "TUFMEAASEgoOTUFJTF9UWVBFX1NUQVIQAUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MailType) }, null, null));
	}
}
