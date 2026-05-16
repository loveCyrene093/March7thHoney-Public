using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeGroupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeGroupReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRDaGFsbGVuZ2VHcm91cC5wcm90byJECg5DaGFsbGVuZ2VHcm91cBIQCghn" + "cm91cF9pZBgDIAEoDRIgChh0YWtlbl9zdGFyc19jb3VudF9yZXdhcmQYDiAB" + "KARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeGroup), ChallengeGroup.Parser, new string[2] { "GroupId", "TakenStarsCountReward" }, null, null, null, null)
		}));
	}
}
