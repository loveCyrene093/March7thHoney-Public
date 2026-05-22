using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NpcMonsterExtraInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NpcMonsterExtraInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlOcGNNb25zdGVyRXh0cmFJbmZvLnByb3RvGhlOcGNNb25zdGVyUm9ndWVJ" + "bmZvLnByb3RvIkQKE05wY01vbnN0ZXJFeHRyYUluZm8SLQoPcm9ndWVfZ2Ft" + "ZV9pbmZvGAcgASgLMhQuTnBjTW9uc3RlclJvZ3VlSW5mb0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NpcMonsterRogueInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcMonsterExtraInfo), NpcMonsterExtraInfo.Parser, new string[1] { "RogueGameInfo" }, null, null, null, null)
		}));
	}
}
