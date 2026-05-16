using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockBackGroundMusicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockBackGroundMusicScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBVbmxvY2tCYWNrR3JvdW5kTXVzaWNTY1JzcC5wcm90bxoPTXVzaWNEYXRh";
		buffer[1] = "LnByb3RvImkKGlVubG9ja0JhY2tHcm91bmRNdXNpY1NjUnNwEiUKEVVubG9j";
		buffer[2] = "a2VkTXVzaWNMaXN0GAcgAygLMgouTXVzaWNEYXRhEhMKC0NIQUtBQU9FREhD";
		buffer[3] = "GAogAygNEg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MusicDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockBackGroundMusicScRsp), UnlockBackGroundMusicScRsp.Parser, new string[3] { "UnlockedMusicList", "CHAKAAOEDHC", "Retcode" }, null, null, null, null)
		}));
	}
}
