using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmStartLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmStartLevelCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNdXNpY1JoeXRobVN0YXJ0TGV2ZWxDc1JlcS5wcm90byIuChpNdXNpY1Jo" + "eXRobVN0YXJ0TGV2ZWxDc1JlcRIQCghsZXZlbF9pZBgFIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmStartLevelCsReq), MusicRhythmStartLevelCsReq.Parser, new string[1] { "LevelId" }, null, null, null, null)
		}));
	}
}
