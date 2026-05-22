using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerSyncScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerSyncScNotifyReflection()
	{
		_003C_003Ey__InlineArray27<string> buffer = default(_003C_003Ey__InlineArray27<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 0) = "ChhQbGF5ZXJTeW5jU2NOb3RpZnkucHJvdG8aEEF2YXRhclN5bmMucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 1) = "FUJhc2ljTW9kdWxlU3luYy5wcm90bxoRRFBCRUdCTklDUEcucHJvdG8aD0Vx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 2) = "dWlwbWVudC5wcm90bxoRSUVCQUlMR0tNTEIucHJvdG8aDkl0ZW1MaXN0LnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 3) = "b3RvGhFMQUVIRE5IUEdDQy5wcm90bxoOTWF0ZXJpYWwucHJvdG8aEU1pc3Np";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 4) = "b25TeW5jLnByb3RvGhFQRkZEQUZKTE5PTy5wcm90bxoVUGxheWVyQmFzaWNJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 5) = "bmZvLnByb3RvGhtQbGF5ZXJCb2FyZE1vZHVsZVN5bmMucHJvdG8aFlBsYXll";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 6) = "ck91dGZpdEluZm8ucHJvdG8aC1F1ZXN0LnByb3RvGgtSZWxpYy5wcm90bxoQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 7) = "U3luY1N0YXR1cy5wcm90bxoVV2FpdERlbFJlc291cmNlLnByb3RvIqIGChJQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 8) = "bGF5ZXJTeW5jU2NOb3RpZnkSIAoLYXZhdGFyX3N5bmMYASABKAsyCy5BdmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 9) = "YXJTeW5jEiIKDG1pc3Npb25fc3luYxgEIAEoCzIMLk1pc3Npb25TeW5jEhoK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 10) = "CnJlbGljX2xpc3QYBSADKAsyBi5SZWxpYxIiCg5lcXVpcG1lbnRfbGlzdBgG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 11) = "IAMoCzIKLkVxdWlwbWVudBITCgtDSkVGQ01BQ0pMRxgHIAMoDRIwChZ3YWl0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 12) = "X2RlbF9yZXNvdXJjZV9saXN0GAkgAygLMhAuV2FpdERlbFJlc291cmNlEhYK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 13) = "DmRlbF9yZWxpY19saXN0GAogAygNEisKEWJhc2ljX21vZHVsZV9zeW5jGAsg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 14) = "ASgLMhAuQmFzaWNNb2R1bGVTeW5jEiAKDW1hdGVyaWFsX2xpc3QYDCADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 15) = "CS5NYXRlcmlhbBIaCgpxdWVzdF9saXN0GA0gAygLMgYuUXVlc3QSJAoKYmFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 16) = "aWNfaW5mbxgOIAEoCzIQLlBsYXllckJhc2ljSW5mbxIhCgtJSUJEQURORkxG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 17) = "UBgiIAMoCzIMLkRQQkVHQk5JQ1BHEh4KC0VEQUhHRUFNRENGGEUgASgLMgku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 18) = "SXRlbUxpc3QSIgoLRkZFRU5CUFBHTkcY3AEgASgLMgwuSUVCQUlMR0tNTEIS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 19) = "HwoLR0hHS0NGSUZNQkIY5wEgAygLMgkuTWF0ZXJpYWwSIQoLc3luY19zdGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 20) = "dXMYwgIgASgLMgsuU3luY1N0YXR1cxIeChV0b3RhbF9hY2hpZXZlbWVudF9l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 21) = "eHAY9QcgASgNEiwKEFBsYXllck91dGZpdERhdGEYkgkgASgLMhEuUGxheWVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 22) = "T3V0Zml0SW5mbxIiCgtQRUZNS0xLS0NGShiHCiADKAsyDC5QRkZEQUZKTE5P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 23) = "TxI4ChdwbGF5ZXJib2FyZF9tb2R1bGVfc3luYxi3CiABKAsyFi5QbGF5ZXJC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 24) = "b2FyZE1vZHVsZVN5bmMSGwoSZGVsX2VxdWlwbWVudF9saXN0GMILIAMoDRIi";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 25) = "CgtOQUpOQkNEQklITxisDiADKAsyDC5MQUVIRE5IUEdDQ0IWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 26) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray27<string>, string>(in buffer, 27))), new FileDescriptor[17]
		{
			AvatarSyncReflection.Descriptor,
			BasicModuleSyncReflection.Descriptor,
			DPBEGBNICPGReflection.Descriptor,
			EquipmentReflection.Descriptor,
			IEBAILGKMLBReflection.Descriptor,
			ItemListReflection.Descriptor,
			LAEHDNHPGCCReflection.Descriptor,
			MaterialReflection.Descriptor,
			MissionSyncReflection.Descriptor,
			PFFDAFJLNOOReflection.Descriptor,
			PlayerBasicInfoReflection.Descriptor,
			PlayerBoardModuleSyncReflection.Descriptor,
			PlayerOutfitInfoReflection.Descriptor,
			QuestReflection.Descriptor,
			RelicReflection.Descriptor,
			SyncStatusReflection.Descriptor,
			WaitDelResourceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerSyncScNotify), PlayerSyncScNotify.Parser, new string[22]
			{
				"AvatarSync", "MissionSync", "RelicList", "EquipmentList", "CJEFCMACJLG", "WaitDelResourceList", "DelRelicList", "BasicModuleSync", "MaterialList", "QuestList",
				"BasicInfo", "IIBDADNFLFP", "EDAHGEAMDCF", "FFEENBPPGNG", "GHGKCFIFMBB", "SyncStatus", "TotalAchievementExp", "PlayerOutfitData", "PEFMKLKKCFJ", "PlayerboardModuleSync",
				"DelEquipmentList", "NAJNBCDBIHO"
			}, null, null, null, null)
		}));
	}
}
