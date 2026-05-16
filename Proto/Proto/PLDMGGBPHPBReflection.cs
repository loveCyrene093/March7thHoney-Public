using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLDMGGBPHPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLDMGGBPHPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTERNR0dCUEhQQi5wcm90byJgCgtQTERNR0dCUEhQQhIQCghza2lsbF9p" + "ZBgBIAEoDRITCgtKSEZLQU5LR0xKThgCIAEoARIaChJiYXR0bGVfdGFyZ2V0" + "X2xpc3QYAyADKA0SDgoGZGFtYWdlGAQgASgBQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PLDMGGBPHPB), PLDMGGBPHPB.Parser, new string[4] { "SkillId", "JHFKANKGLJN", "BattleTargetList", "Damage" }, null, null, null, null)
		}));
	}
}
