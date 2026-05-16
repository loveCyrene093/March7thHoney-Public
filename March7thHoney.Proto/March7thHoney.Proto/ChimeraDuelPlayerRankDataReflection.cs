using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelPlayerRankDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelPlayerRankDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGltZXJhRHVlbFBsYXllclJhbmtEYXRhLnByb3RvIjsKGUNoaW1lcmFE" + "dWVsUGxheWVyUmFua0RhdGESEAoIc2NvcmVfaWQYASABKA0SDAoEcmFuaxgD" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelPlayerRankData), ChimeraDuelPlayerRankData.Parser, new string[2] { "ScoreId", "Rank" }, null, null, null, null)
		}));
	}
}
