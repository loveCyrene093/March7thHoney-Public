using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleEventBattleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleEventBattleInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtCYXR0bGVFdmVudEJhdHRsZUluZm8ucHJvdG8aGUJhdHRsZUV2ZW50UHJv";
		buffer[1] = "cGVydHkucHJvdG8aEVBMRE1HR0JQSFBCLnByb3RvIngKFUJhdHRsZUV2ZW50";
		buffer[2] = "QmF0dGxlSW5mbxIXCg9iYXR0bGVfZXZlbnRfaWQYASABKA0SJAoGc3RhdHVz";
		buffer[3] = "GAIgASgLMhQuQmF0dGxlRXZlbnRQcm9wZXJ0eRIgCgpza2lsbF9pbmZvGAMg";
		buffer[4] = "AygLMgwuUExETUdHQlBIUEJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[5] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BattleEventPropertyReflection.Descriptor,
			PLDMGGBPHPBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleEventBattleInfo), BattleEventBattleInfo.Parser, new string[3] { "BattleEventId", "Status", "SkillInfo" }, null, null, null, null)
		}));
	}
}
