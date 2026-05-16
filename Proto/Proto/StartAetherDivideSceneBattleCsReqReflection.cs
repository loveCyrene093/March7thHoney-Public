using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartAetherDivideSceneBattleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartAetherDivideSceneBattleCsReqReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "CidTdGFydEFldGhlckRpdmlkZVNjZW5lQmF0dGxlQ3NSZXEucHJvdG8aHUFz";
		buffer[1] = "c2lzdE1vbnN0ZXJFbnRpdHlJbmZvLnByb3RvItQBCiFTdGFydEFldGhlckRp";
		buffer[2] = "dmlkZVNjZW5lQmF0dGxlQ3NSZXESEwoLc2tpbGxfaW5kZXgYAiABKA0SHQoV";
		buffer[3] = "YXR0YWNrZWRfYnlfZW50aXR5X2lkGAggASgNEhYKDmNhc3RfZW50aXR5X2lk";
		buffer[4] = "GAkgASgNEiUKHWFzc2lzdF9tb25zdGVyX2VudGl0eV9pZF9saXN0GAsgAygN";
		buffer[5] = "EjwKGmFzc2lzdF9tb25zdGVyX2VudGl0eV9pbmZvGAwgAygLMhguQXNzaXN0";
		buffer[6] = "TW9uc3RlckVudGl0eUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[7] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AssistMonsterEntityInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideSceneBattleCsReq), StartAetherDivideSceneBattleCsReq.Parser, new string[5] { "SkillIndex", "AttackedByEntityId", "CastEntityId", "AssistMonsterEntityIdList", "AssistMonsterEntityInfo" }, null, null, null, null)
		}));
	}
}
