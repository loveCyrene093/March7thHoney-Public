using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmFinishLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmFinishLevelScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNdXNpY1JoeXRobUZpbmlzaExldmVsU2NSc3AucHJvdG8iQAobTXVzaWNS" + "aHl0aG1GaW5pc2hMZXZlbFNjUnNwEhAKCGxldmVsX2lkGAkgASgNEg8KB3Jl" + "dGNvZGUYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmFinishLevelScRsp), MusicRhythmFinishLevelScRsp.Parser, new string[2] { "LevelId", "Retcode" }, null, null, null, null)
		}));
	}
}
