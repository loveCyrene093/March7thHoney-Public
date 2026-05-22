using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneCastSkillCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneCastSkillCsReqReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 0) = "ChlTY2VuZUNhc3RTa2lsbENzUmVxLnByb3RvGh1Bc3Npc3RNb25zdGVyRW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 1) = "aXR5SW5mby5wcm90bxoTRHluYW1pY1ZhbHVlcy5wcm90bxoQTW90aW9uSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 2) = "by5wcm90bxoTU2tpbGxFeHRyYVRhZy5wcm90byKOAwoTU2NlbmVDYXN0U2tp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 3) = "bGxDc1JlcRIhChloaXRfdGFyZ2V0X2VudGl0eV9pZF9saXN0GAEgAygNEh0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 4) = "FWF0dGFja2VkX2J5X2VudGl0eV9pZBgCIAEoDRI8Chphc3Npc3RfbW9uc3Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 5) = "cl9lbnRpdHlfaW5mbxgDIAMoCzIYLkFzc2lzdE1vbnN0ZXJFbnRpdHlJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 6) = "EhgKEG1hemVfYWJpbGl0eV9zdHIYBCABKAkSFgoOY2FzdF9lbnRpdHlfaWQY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 7) = "BSABKA0SEwoLSkpBQk5NRkxLS0kYBiABKA0SIgoNdGFyZ2V0X21vdGlvbhgH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 8) = "IAEoCzILLk1vdGlvbkluZm8SEwoLc2tpbGxfaW5kZXgYCCABKA0SJQodYXNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 9) = "aXN0X21vbnN0ZXJfZW50aXR5X2lkX2xpc3QYCSADKA0SJgoOZHluYW1pY192";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 10) = "YWx1ZXMYDSADKAsyDi5EeW5hbWljVmFsdWVzEigKEHNraWxsX2V4dHJhX3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 11) = "Z3MYDiADKA4yDi5Ta2lsbEV4dHJhVGFnQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 12) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray13<string>, string>(in buffer, 13))), new FileDescriptor[4]
		{
			AssistMonsterEntityInfoReflection.Descriptor,
			DynamicValuesReflection.Descriptor,
			MotionInfoReflection.Descriptor,
			SkillExtraTagReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneCastSkillCsReq), SceneCastSkillCsReq.Parser, new string[11]
			{
				"HitTargetEntityIdList", "AttackedByEntityId", "AssistMonsterEntityInfo", "MazeAbilityStr", "CastEntityId", "JJABNMFLKKI", "TargetMotion", "SkillIndex", "AssistMonsterEntityIdList", "DynamicValues",
				"SkillExtraTags"
			}, null, null, null, null)
		}));
	}
}
