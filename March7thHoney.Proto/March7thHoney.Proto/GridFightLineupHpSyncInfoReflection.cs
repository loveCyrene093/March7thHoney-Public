using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightLineupHpSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightLineupHpSyncInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HcmlkRmlnaHRMaW5ldXBIcFN5bmNJbmZvLnByb3RvIlsKGUdyaWRGaWdo" + "dExpbmV1cEhwU3luY0luZm8SIAoYZ3JpZF9maWdodF9saW5ldXBfbWF4X2hw" + "GA0gASgNEhwKFGdyaWRfZmlnaHRfbGluZXVwX2hwGA4gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightLineupHpSyncInfo), GridFightLineupHpSyncInfo.Parser, new string[2] { "GridFightLineupMaxHp", "GridFightLineupHp" }, null, null, null, null)
		}));
	}
}
