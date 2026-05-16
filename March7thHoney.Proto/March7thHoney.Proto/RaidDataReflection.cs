using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5SYWlkRGF0YS5wcm90bxoUUmFpZFRhcmdldEluZm8ucHJvdG8iWwoIUmFp" + "ZERhdGESEwoLd29ybGRfbGV2ZWwYBiABKA0SDwoHcmFpZF9pZBgHIAEoDRIp" + "ChByYWlkX3RhcmdldF9pbmZvGA8gAygLMg8uUmFpZFRhcmdldEluZm9CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { RaidTargetInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RaidData), RaidData.Parser, new string[3] { "WorldLevel", "RaidId", "RaidTargetInfo" }, null, null, null, null)
		}));
	}
}
