using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmFinishLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmFinishLevelCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNdXNpY1JoeXRobUZpbmlzaExldmVsQ3NSZXEucHJvdG8iVgobTXVzaWNS" + "aHl0aG1GaW5pc2hMZXZlbENzUmVxEhAKCHNjb3JlX2lkGAEgASgNEhIKCmZ1" + "bGxfY29tYm8YDCABKAgSEQoJcm9sZV9zdGFyGA8gASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmFinishLevelCsReq), MusicRhythmFinishLevelCsReq.Parser, new string[3] { "ScoreId", "FullCombo", "RoleStar" }, null, null, null, null)
		}));
	}
}
