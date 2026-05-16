using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChatTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChatTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5DaGF0VHlwZS5wcm90bypKCghDaGF0VHlwZRISCg5DSEFUX1RZUEVfTk9O" + "RRAAEhUKEUNIQVRfVFlQRV9QUklWQVRFEAESEwoPQ0hBVF9UWVBFX0dST1VQ" + "EAJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChatType) }, null, null));
	}
}
