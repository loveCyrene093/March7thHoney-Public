using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossStatisticsReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossStatisticsReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGFsbGVuZ2VCb3NzU3RhdGlzdGljcy5wcm90bxoRQkhGQUZNREhLS0Mu" + "cHJvdG8iTwoXQ2hhbGxlbmdlQm9zc1N0YXRpc3RpY3MSIQoLTkNFR0VLTkxK" + "Q0UYCSABKAsyDC5CSEZBRk1ESEtLQxIRCglyZWNvcmRfaWQYDCABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { BHFAFMDHKKCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossStatistics), ChallengeBossStatistics.Parser, new string[2] { "NCEGEKNLJCE", "RecordId" }, null, null, null, null)
		}));
	}
}
