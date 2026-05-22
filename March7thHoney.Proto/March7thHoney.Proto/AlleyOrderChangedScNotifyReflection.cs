using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AlleyOrderChangedScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AlleyOrderChangedScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9BbGxleU9yZGVyQ2hhbmdlZFNjTm90aWZ5LnByb3RvGhFQTElFRURLSEdO" + "Ti5wcm90byI+ChlBbGxleU9yZGVyQ2hhbmdlZFNjTm90aWZ5EiEKC0ZDTE1P" + "T0tKR1BOGAUgASgLMgwuUExJRUVES0hHTk5CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { PLIEEDKHGNNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AlleyOrderChangedScNotify), AlleyOrderChangedScNotify.Parser, new string[1] { "FCLMOOKJGPN" }, null, null, null, null)
		}));
	}
}
