using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpNdXNpY1JoeXRobURhdGFDc1JlcS5wcm90byIrChRNdXNpY1JoeXRobURh" + "dGFDc1JlcRITCgtwbGF5ZXJfZGF0YRgEIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmDataCsReq), MusicRhythmDataCsReq.Parser, new string[1] { "PlayerData" }, null, null, null, null)
		}));
	}
}
