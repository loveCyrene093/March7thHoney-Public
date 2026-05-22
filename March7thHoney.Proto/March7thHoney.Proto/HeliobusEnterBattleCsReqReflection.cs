using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusEnterBattleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusEnterBattleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5IZWxpb2J1c0VudGVyQmF0dGxlQ3NSZXEucHJvdG8iVgoYSGVsaW9idXNF" + "bnRlckJhdHRsZUNzUmVxEhAKCGV2ZW50X2lkGAggASgNEhYKDmF2YXRhcl9p" + "ZF9saXN0GAogAygNEhAKCHNraWxsX2lkGAsgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusEnterBattleCsReq), HeliobusEnterBattleCsReq.Parser, new string[3] { "EventId", "AvatarIdList", "SkillId" }, null, null, null, null)
		}));
	}
}
