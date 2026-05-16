using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneCastSkillCostMpCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneCastSkillCostMpCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TY2VuZUNhc3RTa2lsbENvc3RNcENzUmVxLnByb3RvImcKGVNjZW5lQ2Fz" + "dFNraWxsQ29zdE1wQ3NSZXESHQoVYXR0YWNrZWRfYnlfZW50aXR5X2lkGAgg" + "ASgNEhMKC3NraWxsX2luZGV4GAkgASgNEhYKDmNhc3RfZW50aXR5X2lkGA8g" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneCastSkillCostMpCsReq), SceneCastSkillCostMpCsReq.Parser, new string[3] { "AttackedByEntityId", "SkillIndex", "CastEntityId" }, null, null, null, null)
		}));
	}
}
