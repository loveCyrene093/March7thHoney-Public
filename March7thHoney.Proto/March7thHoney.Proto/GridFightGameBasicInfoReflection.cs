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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 0) = "ChxHcmlkRmlnaHRHYW1lQmFzaWNJbmZvLnByb3RvGhdHcmlkRmlnaHRMb2Nr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 1) = "SW5mby5wcm90bxoXR3JpZEZpZ2h0TG9ja1R5cGUucHJvdG8aIkdyaWRGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 2) = "dFN5bmNDdXJyZW50VGFza0luZm8ucHJvdG8aHFJvbGVUcmFja0VxdWlwbWVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 3) = "dEluZm8ucHJvdG8iuQUKFkdyaWRGaWdodEdhbWVCYXNpY0luZm8SIAoYZ3Jp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 4) = "ZF9maWdodF9saW5ldXBfbWF4X2hwGAEgASgNEiUKCWxvY2tfdHlwZRgCIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 5) = "DjISLkdyaWRGaWdodExvY2tUeXBlEhMKC0ZMRUpQUEtMSklDGAMgASgNEgwK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 6) = "BGdvbGQYBCABKA0SEwoLSEFFT1BLRUxORU8YBSABKA0SIwobZ3JpZF9maWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 7) = "dF9tYXhfYXZhdGFyX2NvdW50GAYgASgNEiAKGGdyaWRfZmlnaHRfY3VyX2xl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 8) = "dmVsX2V4cBgHIAEoDRIbChN0cmFja190cmFpdF9pZF9saXN0GAggAygNEh8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 9) = "F2dyaWRfZmlnaHRfYnV5X2V4cF9jb3N0GAkgASgNEjoKGXJvbGVfdHJhY2tf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 10) = "ZXF1aXBtZW50X2xpc3QYCiADKAsyFy5Sb2xlVHJhY2tFcXVpcG1lbnRJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 11) = "EiQKHGdyaWRfZmlnaHRfbWF4X2ludGVyZXN0X2dvbGQYCyABKA0SHAoUZ3Jp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 12) = "ZF9maWdodF9saW5ldXBfaHAYDCABKA0SEwoLQU5CQlBQSEJDSkgYDSABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 13) = "IAoYZ3JpZF9maWdodF9jb21ib193aW5fbnVtGA4gASgNEiYKHmdyaWRfZmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 14) = "aHRfb2ZmX2ZpZWxkX21heF9jb3VudBgPIAEoDRIrCg5nYW1lX2xvY2tfaW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 15) = "bxikAiABKAsyEi5HcmlkRmlnaHRMb2NrSW5mbxIlChxncmlkX2ZpZ2h0X3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 16) = "cmdldF9ndWlkZV9jb2RlGM4CIAEoCRJEChxncmlkX2ZpZ2h0X3N5bmNfY3Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 17) = "dGFza19pbmZvGJ4EIAEoCzIdLkdyaWRGaWdodFN5bmNDdXJyZW50VGFza0lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 18) = "Zm8SIAoXdHV0b3JpYWxfdW5sb2NrX2lkX2xpc3QYzQ0gAygNQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 19) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray20<string>, string>(in buffer, 20))), new FileDescriptor[4]
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
