using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9NdXNpY0RhdGEucHJvdG8iOwoJTXVzaWNEYXRhEgoKAmlkGAggASgNEhAK" + "CElzUGxheWVkGAogASgIEhAKCGdyb3VwX2lkGA8gASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicData), MusicData.Parser, new string[3] { "Id", "IsPlayed", "GroupId" }, null, null, null, null)
		}));
	}
}
