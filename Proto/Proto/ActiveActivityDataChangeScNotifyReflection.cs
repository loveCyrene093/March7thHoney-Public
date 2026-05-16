using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActiveActivityDataChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActiveActivityDataChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZBY3RpdmVBY3Rpdml0eURhdGFDaGFuZ2VTY05vdGlmeS5wcm90bxoYQWN0" + "aXZlQWN0aXZpdHlEYXRhLnByb3RvIkwKIEFjdGl2ZUFjdGl2aXR5RGF0YUNo" + "YW5nZVNjTm90aWZ5EigKC01MQkxQQkxJSkNBGAUgASgLMhMuQWN0aXZlQWN0" + "aXZpdHlEYXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ActiveActivityDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActiveActivityDataChangeScNotify), ActiveActivityDataChangeScNotify.Parser, new string[1] { "MLBLPBLIJCA" }, null, null, null, null)
		}));
	}
}
