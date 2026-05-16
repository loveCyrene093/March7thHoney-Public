using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeStatisticsReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeStatisticsReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDaGFsbGVuZ2VTdGF0aXN0aWNzLnByb3RvGhFGUERLQkdKS1BGRi5wcm90" + "byJLChNDaGFsbGVuZ2VTdGF0aXN0aWNzEhEKCXJlY29yZF9pZBgKIAEoDRIh" + "CgtOQ0VHRUtOTEpDRRgOIAEoCzIMLkZQREtCR0pLUEZGQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { FPDKBGJKPFFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStatistics), ChallengeStatistics.Parser, new string[2] { "RecordId", "NCEGEKNLJCE" }, null, null, null, null)
		}));
	}
}
