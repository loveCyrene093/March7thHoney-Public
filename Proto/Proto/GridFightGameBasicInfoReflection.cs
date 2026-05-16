using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameBasicInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameBasicInfoReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		buffer[0] = "ChxHcmlkRmlnaHRHYW1lQmFzaWNJbmZvLnByb3RvGhdHcmlkRmlnaHRMb2Nr";
		buffer[1] = "SW5mby5wcm90bxoXR3JpZEZpZ2h0TG9ja1R5cGUucHJvdG8aIkdyaWRGaWdo";
		buffer[2] = "dFN5bmNDdXJyZW50VGFza0luZm8ucHJvdG8aHFJvbGVUcmFja0VxdWlwbWVu";
		buffer[3] = "dEluZm8ucHJvdG8iuQUKFkdyaWRGaWdodEdhbWVCYXNpY0luZm8SIAoYZ3Jp";
		buffer[4] = "ZF9maWdodF9saW5ldXBfbWF4X2hwGAEgASgNEiUKCWxvY2tfdHlwZRgCIAEo";
		buffer[5] = "DjISLkdyaWRGaWdodExvY2tUeXBlEhMKC0ZMRUpQUEtMSklDGAMgASgNEgwK";
		buffer[6] = "BGdvbGQYBCABKA0SEwoLSEFFT1BLRUxORU8YBSABKA0SIwobZ3JpZF9maWdo";
		buffer[7] = "dF9tYXhfYXZhdGFyX2NvdW50GAYgASgNEiAKGGdyaWRfZmlnaHRfY3VyX2xl";
		buffer[8] = "dmVsX2V4cBgHIAEoDRIbChN0cmFja190cmFpdF9pZF9saXN0GAggAygNEh8K";
		buffer[9] = "F2dyaWRfZmlnaHRfYnV5X2V4cF9jb3N0GAkgASgNEjoKGXJvbGVfdHJhY2tf";
		buffer[10] = "ZXF1aXBtZW50X2xpc3QYCiADKAsyFy5Sb2xlVHJhY2tFcXVpcG1lbnRJbmZv";
		buffer[11] = "EiQKHGdyaWRfZmlnaHRfbWF4X2ludGVyZXN0X2dvbGQYCyABKA0SHAoUZ3Jp";
		buffer[12] = "ZF9maWdodF9saW5ldXBfaHAYDCABKA0SEwoLQU5CQlBQSEJDSkgYDSABKA0S";
		buffer[13] = "IAoYZ3JpZF9maWdodF9jb21ib193aW5fbnVtGA4gASgNEiYKHmdyaWRfZmln";
		buffer[14] = "aHRfb2ZmX2ZpZWxkX21heF9jb3VudBgPIAEoDRIrCg5nYW1lX2xvY2tfaW5m";
		buffer[15] = "bxikAiABKAsyEi5HcmlkRmlnaHRMb2NrSW5mbxIlChxncmlkX2ZpZ2h0X3Rh";
		buffer[16] = "cmdldF9ndWlkZV9jb2RlGM4CIAEoCRJEChxncmlkX2ZpZ2h0X3N5bmNfY3Vy";
		buffer[17] = "dGFza19pbmZvGJ4EIAEoCzIdLkdyaWRGaWdodFN5bmNDdXJyZW50VGFza0lu";
		buffer[18] = "Zm8SIAoXdHV0b3JpYWxfdW5sb2NrX2lkX2xpc3QYzQ0gAygNQhaqAhNNYXJj";
		buffer[19] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			GridFightLockInfoReflection.Descriptor,
			GridFightLockTypeReflection.Descriptor,
			GridFightSyncCurrentTaskInfoReflection.Descriptor,
			RoleTrackEquipmentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameBasicInfo), GridFightGameBasicInfo.Parser, new string[19]
			{
				"GridFightLineupMaxHp", "LockType", "FLEJPPKLJIC", "Gold", "HAEOPKELNEO", "GridFightMaxAvatarCount", "GridFightCurLevelExp", "TrackTraitIdList", "GridFightBuyExpCost", "RoleTrackEquipmentList",
				"GridFightMaxInterestGold", "GridFightLineupHp", "ANBBPPHBCJH", "GridFightComboWinNum", "GridFightOffFieldMaxCount", "GameLockInfo", "GridFightTargetGuideCode", "GridFightSyncCurtaskInfo", "TutorialUnlockIdList"
			}, null, null, null, null)
		}));
	}
}
