using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesTakeQuestRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesTakeQuestRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNQbGFuZXRGZXNUYWtlUXVlc3RSZXdhcmRDc1JlcS5wcm90byIxCh1QbGFu" + "ZXRGZXNUYWtlUXVlc3RSZXdhcmRDc1JlcRIQCghxdWVzdF9pZBgFIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesTakeQuestRewardCsReq), PlanetFesTakeQuestRewardCsReq.Parser, new string[1] { "QuestId" }, null, null, null, null)
		}));
	}
}
