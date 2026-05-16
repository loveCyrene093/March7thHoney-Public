using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmSaveSongConfigDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmSaveSongConfigDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihNdXNpY1JoeXRobVNhdmVTb25nQ29uZmlnRGF0YUNzUmVxLnByb3RvGhZN" + "dXNpY1JoeXRobUdyb3VwLnByb3RvIkwKIk11c2ljUmh5dGhtU2F2ZVNvbmdD" + "b25maWdEYXRhQ3NSZXESJgoLQkFKRUlBTElCQk0YDiABKAsyES5NdXNpY1Jo" + "eXRobUdyb3VwQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MusicRhythmGroupReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmSaveSongConfigDataCsReq), MusicRhythmSaveSongConfigDataCsReq.Parser, new string[1] { "BAJEIALIBBM" }, null, null, null, null)
		}));
	}
}
