using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneInfoReflection()
	{
		_003C_003Ey__InlineArray27<string> buffer = default(_003C_003Ey__InlineArray27<string>);
		buffer[0] = "Cg9TY2VuZUluZm8ucHJvdG8aDkJ1ZmZJbmZvLnByb3RvGhRDdXN0b21TYXZl";
		buffer[1] = "RGF0YS5wcm90bxoRRFBOREpJR0FDRkoucHJvdG8aEUlBSEhMSU9MQ0RCLnBy";
		buffer[2] = "b3RvGh5NaXNzaW9uU3RhdHVzQnlTY2VuZUluZm8ucHJvdG8aEU5CQ09PTExF";
		buffer[3] = "T0lELnByb3RvGhpTY2VuZUVudGl0eUdyb3VwSW5mby5wcm90bxoVU2NlbmVF";
		buffer[4] = "bnRpdHlJbmZvLnByb3RvGhVTY2VuZUdyb3VwU3RhdGUucHJvdG8aFVNjZW5l";
		buffer[5] = "SWRlbnRpZmllci5wcm90byKoBwoJU2NlbmVJbmZvEhYKDmdhbWVfbW9kZV90";
		buffer[6] = "eXBlGAEgASgNEiEKC05IT0ZNSE1CS0dLGAMgAygLMgwuTkJDT09MTEVPSUQS";
		buffer[7] = "GgoSY2xpZW50X3Bvc192ZXJzaW9uGAQgASgNEhAKCHBsYW5lX2lkGAUgASgN";
		buffer[8] = "EjAKC0tISE9QTkpKQUJIGAYgAygLMhsuU2NlbmVJbmZvLktISE9QTkpKQUJI";
		buffer[9] = "RW50cnkSKQoQY3VzdG9tX2RhdGFfbGlzdBgHIAMoCzIPLkN1c3RvbVNhdmVE";
		buffer[10] = "YXRhEiUKC2VudGl0eV9saXN0GAkgAygLMhAuU2NlbmVFbnRpdHlJbmZvEhAK";
		buffer[11] = "CGZsb29yX2lkGAogASgNEicKFHNjZW5lX2J1ZmZfaW5mb19saXN0GAsgAygL";
		buffer[12] = "MgkuQnVmZkluZm8SEAoIZW50cnlfaWQYDCABKA0SGAoQbGVhZGVyX2VudGl0";
		buffer[13] = "eV9pZBgNIAEoDRIcChRsaWdodGVuX3NlY3Rpb25fbGlzdBgOIAMoDRIQCgh3";
		buffer[14] = "b3JsZF9pZBgPIAEoDRIVCgxkaW1lbnNpb25faWQYkwQgASgNEhsKEmdhbWVf";
		buffer[15] = "c3RvcnlfbGluZV9pZBjaBCABKA0SOQoQZmxvb3Jfc2F2ZWRfZGF0YRioBSAD";
		buffer[16] = "KAsyHi5TY2VuZUluZm8uRmxvb3JTYXZlZERhdGFFbnRyeRIbChJvcGVuZWRf";
		buffer[17] = "Y2hlc3RzX2xpc3QYzwUgAygNEhMKCmNvbnRlbnRfaWQY2gcgASgNEjEKEWVu";
		buffer[18] = "dGl0eV9ncm91cF9saXN0GIEJIAMoCzIVLlNjZW5lRW50aXR5R3JvdXBJbmZv";
		buffer[19] = "EiIKC09DS05LQ0NJSkFJGLkKIAEoCzIMLkRQTkRKSUdBQ0ZKEjYKEnNjZW5l";
		buffer[20] = "X21pc3Npb25faW5mbxiBDCABKAsyGS5NaXNzaW9uU3RhdHVzQnlTY2VuZUlu";
		buffer[21] = "Zm8SKwoQZ3JvdXBfc3RhdGVfbGlzdBiRDCADKAsyEC5TY2VuZUdyb3VwU3Rh";
		buffer[22] = "dGUSFAoLaW50ZXJhY3RfaWQY0A0gASgEEisKEHNjZW5lX2lkZW50aWZpZXIY";
		buffer[23] = "mw8gASgLMhAuU2NlbmVJZGVudGlmaWVyGkAKEEtISE9QTkpKQUJIRW50cnkS";
		buffer[24] = "CwoDa2V5GAEgASgNEhsKBXZhbHVlGAIgASgLMgwuSUFISExJT0xDREI6AjgB";
		buffer[25] = "GjUKE0Zsb29yU2F2ZWREYXRhRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVl";
		buffer[26] = "GAIgASgFOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[10]
		{
			BuffInfoReflection.Descriptor,
			CustomSaveDataReflection.Descriptor,
			DPNDJIGACFJReflection.Descriptor,
			IAHHLIOLCDBReflection.Descriptor,
			MissionStatusBySceneInfoReflection.Descriptor,
			NBCOOLLEOIDReflection.Descriptor,
			SceneEntityGroupInfoReflection.Descriptor,
			SceneEntityInfoReflection.Descriptor,
			SceneGroupStateReflection.Descriptor,
			SceneIdentifierReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneInfo), SceneInfo.Parser, new string[24]
			{
				"GameModeType", "NHOFMHMBKGK", "ClientPosVersion", "PlaneId", "KHHOPNJJABH", "CustomDataList", "EntityList", "FloorId", "SceneBuffInfoList", "EntryId",
				"LeaderEntityId", "LightenSectionList", "WorldId", "DimensionId", "GameStoryLineId", "FloorSavedData", "OpenedChestsList", "ContentId", "EntityGroupList", "OCKNKCCIJAI",
				"SceneMissionInfo", "GroupStateList", "InteractId", "SceneIdentifier"
			}, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
