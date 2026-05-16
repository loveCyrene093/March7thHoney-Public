using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneMapInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneMapInfoReflection()
	{
		_003C_003Ey__InlineArray18<string> buffer = default(_003C_003Ey__InlineArray18<string>);
		buffer[0] = "ChJTY2VuZU1hcEluZm8ucHJvdG8aD0NoZXN0SW5mby5wcm90bxoPTWF6ZUdy";
		buffer[1] = "b3VwLnByb3RvGhNNYXplUHJvcFN0YXRlLnByb3RvGh5NaXNzaW9uU3RhdHVz";
		buffer[2] = "QnlTY2VuZUluZm8ucHJvdG8aEVBMREhKR0FFRUFFLnByb3RvGhVTY2VuZUlk";
		buffer[3] = "ZW50aWZpZXIucHJvdG8i7gQKDFNjZW5lTWFwSW5mbxIQCghlbnRyeV9pZBgB";
		buffer[4] = "IAEoDRI7ChBmbG9vcl9zYXZlZF9kYXRhGAIgAygLMiEuU2NlbmVNYXBJbmZv";
		buffer[5] = "LkZsb29yU2F2ZWREYXRhRW50cnkSGAoQY3VyX21hcF9lbnRyeV9pZBgDIAEo";
		buffer[6] = "DRIjCg9tYXplX2dyb3VwX2xpc3QYBSADKAsyCi5NYXplR3JvdXASJgoObWF6";
		buffer[7] = "ZV9wcm9wX2xpc3QYBiADKAsyDi5NYXplUHJvcFN0YXRlEhAKCGZsb29yX2lk";
		buffer[8] = "GAcgASgNEhQKDGRpbWVuc2lvbl9pZBgJIAEoDRIcChRsaWdodGVuX3NlY3Rp";
		buffer[9] = "b25fbGlzdBgLIAMoDRIeCgpjaGVzdF9saXN0GAwgAygLMgouQ2hlc3RJbmZv";
		buffer[10] = "EhwKFHVubG9ja190ZWxlcG9ydF9saXN0GA0gAygNEg8KB3JldGNvZGUYDiAB";
		buffer[11] = "KA0SKAoSY2hlc3RfbW9uc3Rlcl9saXN0GA8gAygLMgwuUExESEpHQUVFQUUS";
		buffer[12] = "KwoQc2NlbmVfaWRlbnRpZmllchj/AiABKAsyEC5TY2VuZUlkZW50aWZpZXIS";
		buffer[13] = "HQoUb3BlbmVkX2NoZXN0X2lkX2xpc3QYvAYgAygNEj0KGWNsaWVudF9ncm91";
		buffer[14] = "cF9taXNzaW9uX2luZm8Y/QYgASgLMhkuTWlzc2lvblN0YXR1c0J5U2NlbmVJ";
		buffer[15] = "bmZvEicKHmZpbmlzaGVkX2NoZXN0X21vbnN0ZXJfaWRfbGlzdBi1DSADKA0a";
		buffer[16] = "NQoTRmxvb3JTYXZlZERhdGFFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY";
		buffer[17] = "AiABKAU6AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[6]
		{
			ChestInfoReflection.Descriptor,
			MazeGroupReflection.Descriptor,
			MazePropStateReflection.Descriptor,
			MissionStatusBySceneInfoReflection.Descriptor,
			PLDHJGAEEAEReflection.Descriptor,
			SceneIdentifierReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneMapInfo), SceneMapInfo.Parser, new string[16]
			{
				"EntryId", "FloorSavedData", "CurMapEntryId", "MazeGroupList", "MazePropList", "FloorId", "DimensionId", "LightenSectionList", "ChestList", "UnlockTeleportList",
				"Retcode", "ChestMonsterList", "SceneIdentifier", "OpenedChestIdList", "ClientGroupMissionInfo", "FinishedChestMonsterIdList"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
