using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSyncDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSyncDataReflection()
	{
		_003C_003Ey__InlineArray76<string> buffer = default(_003C_003Ey__InlineArray76<string>);
		buffer[0] = "ChdHcmlkRmlnaHRTeW5jRGF0YS5wcm90bxoRQ0tDS0lESE1NRUcucHJvdG8a";
		buffer[1] = "EUNMT0VQUEJDS0dGLnByb3RvGhFDTUNKTktQS0JFTS5wcm90bxoRRElCSkdB";
		buffer[2] = "S09DTE8ucHJvdG8aHEdyaWRGaWdodERhbWFnZVN0dEluZm8ucHJvdG8aIkdy";
		buffer[3] = "aWRGaWdodEVsaXRlQnJhbmNoU3luY0luZm8ucHJvdG8aHUdyaWRGaWdodEdh";
		buffer[4] = "bWVBdWdtZW50QWRkLnByb3RvGiBHcmlkRmlnaHRHYW1lQXVnbWVudFVwZGF0";
		buffer[5] = "ZS5wcm90bxobR3JpZEZpZ2h0R2FtZUl0ZW1JbmZvLnByb3RvGh9HcmlkRmln";
		buffer[6] = "aHRHYW1lSXRlbVN5bmNJbmZvLnByb3RvGhxHcmlkRmlnaHRMZXZlbFN5bmNJ";
		buffer[7] = "bmZvLnByb3RvGh9HcmlkRmlnaHRMaW5ldXBIcFN5bmNJbmZvLnByb3RvGhdH";
		buffer[8] = "cmlkRmlnaHRMb2NrSW5mby5wcm90bxoXR3JpZEZpZ2h0TG9ja1R5cGUucHJv";
		buffer[9] = "dG8aGkdyaWRGaWdodE9yYlN5bmNJbmZvLnByb3RvGhxHcmlkRmlnaHRQZW5k";
		buffer[10] = "aW5nQWN0aW9uLnByb3RvGiJHcmlkRmlnaHRQbGF5ZXJMZXZlbFN5bmNJbmZv";
		buffer[11] = "LnByb3RvGiVHcmlkRmlnaHRQb3J0YWxTZXJ2ZXJEYXRhVXBkYXRlLnByb3Rv";
		buffer[12] = "GiBHcmlkRmlnaHRTZWN0aW9uUmVjb3JkSW5mby5wcm90bxobR3JpZEZpZ2h0";
		buffer[13] = "U2hvcFN5bmNJbmZvLnByb3RvGhxHcmlkRmlnaHRUcmFpdFN5bmNJbmZvLnBy";
		buffer[14] = "b3RvGiFHcmlkRmlnaHRUcmFpdFRyYWNrU3luY0luZm8ucHJvdG8aH0dyaWRG";
		buffer[15] = "aWdodFR1dG9yaWFsU3luY0luZm8ucHJvdG8aG0dyaWRHYW1lRm9yZ2VJdGVt";
		buffer[16] = "SW5mby5wcm90bxoVR3JpZEdhbWVOcGNJbmZvLnByb3RvGhVHcmlkR2FtZU9y";
		buffer[17] = "YkluZm8ucHJvdG8aFkdyaWRHYW1lUm9sZUluZm8ucHJvdG8aEUpQQkNLQ0RF";
		buffer[18] = "R09NLnByb3RvGiBSb2xlVHJhY2tFcXVpcG1lbnRTeW5jSW5mby5wcm90byLg";
		buffer[19] = "EwoRR3JpZEZpZ2h0U3luY0RhdGESFQoLQ0pFTUtDT0NFQ0cYEyABKA1IABIe";
		buffer[20] = "ChRyZW1vdmVfb3JiX3VuaXF1ZV9pZBg1IAEoDUgAEkAKGWVxdWlwbWVudF90";
		buffer[21] = "cmFja19zeW5jX2luZm8YOSABKAsyGy5Sb2xlVHJhY2tFcXVpcG1lbnRTeW5j";
		buffer[22] = "SW5mb0gAEh0KE21heF9iYXR0bGVfcm9sZV9udW0YSCABKA1IABIkCgtDRk5Q";
		buffer[23] = "R05NUE5EThiMASABKAsyDC5DTUNKTktQS0JFTUgAEisKDWFkZF9yb2xlX2lu";
		buffer[24] = "Zm8Y0gEgASgLMhEuR3JpZEdhbWVSb2xlSW5mb0gAEikKDGFkZF9ucGNfaW5m";
		buffer[25] = "bxjmASABKAsyEC5HcmlkR2FtZU5wY0luZm9IABIWCgtITEZCQkFOTUpEShiB";
		buffer[26] = "AiABKA1IABIzCg90cmFpdF9zeW5jX2luZm8YggIgASgLMhcuR3JpZEZpZ2h0";
		buffer[27] = "VHJhaXRTeW5jSW5mb0gAEkYKGXBvcnRhbF9zZXJ2ZXJfZGF0YV91cGRhdGUY";
		buffer[28] = "jwIgASgLMiAuR3JpZEZpZ2h0UG9ydGFsU2VydmVyRGF0YVVwZGF0ZUgAEjwK";
		buffer[29] = "FXVwZGF0ZV9nYW1lX2l0ZW1faW5mbxicAiABKAsyGi5HcmlkRmlnaHRHYW1l";
		buffer[30] = "SXRlbVN5bmNJbmZvSAASMQoOYWRkX2ZvcmdlX2luZm8YggMgASgLMhYuR3Jp";
		buffer[31] = "ZEdhbWVGb3JnZUl0ZW1JbmZvSAASLgoQdXBkYXRlX3JvbGVfaW5mbxiJAyAB";
		buffer[32] = "KAsyES5HcmlkR2FtZVJvbGVJbmZvSAASFgoLQUpJTU9BTUdDSUkYpwMgASgN";
		buffer[33] = "SAASPgoaZ3JpZF9maWdodF9kYW1hZ2Vfc3R0X2luZm8YtQMgASgLMhcuR3Jp";
		buffer[34] = "ZEZpZ2h0RGFtYWdlU3R0SW5mb0gAEiMKGGdyaWRfZmlnaHRfY29tYm9fd2lu";
		buffer[35] = "X251bRjNAyABKA1IABItCg5zeW5jX2xvY2tfaW5mbxjUAyABKAsyEi5Hcmlk";
		buffer[36] = "RmlnaHRMb2NrSW5mb0gAEhYKC0dEUEJKREhHRkxCGIQEIAEoDUgAEiMKGHJl";
		buffer[37] = "bW92ZV9hdWdtZW50X3VuaXF1ZV9pZBiLBCABKA1IABImChtncmlkX2ZpZ2h0";
		buffer[38] = "X21heF9hdmF0YXJfY291bnQYpAQgASgNSAASNgoRYXVnbWVudF9zeW5jX2lu";
		buffer[39] = "Zm8YrgQgASgLMhguR3JpZEZpZ2h0R2FtZUF1Z21lbnRBZGRIABIkChlmaW5p";
		buffer[40] = "c2hfcGVuZGluZ19hY3Rpb25fcG9zGL0EIAEoDUgAEjIKDnBlbmRpbmdfYWN0";
		buffer[41] = "aW9uGJIGIAEoCzIXLkdyaWRGaWdodFBlbmRpbmdBY3Rpb25IABIoCgtQT0lQ";
		buffer[42] = "R05IT05NQRieBiABKAsyEC5HcmlkR2FtZU9yYkluZm9IABIzCg9sZXZlbF9z";
		buffer[43] = "eW5jX2luZm8YxgYgASgLMhcuR3JpZEZpZ2h0TGV2ZWxTeW5jSW5mb0gAEicK";
		buffer[44] = "HGdyaWRfZmlnaHRfbWF4X2ludGVyZXN0X2dvbGQY1wYgASgNSAASNAoRdXBk";
		buffer[45] = "YXRlX2ZvcmdlX2luZm8YjQcgASgLMhYuR3JpZEdhbWVGb3JnZUl0ZW1JbmZv";
		buffer[46] = "SAASNgoMcGxheWVyX2xldmVsGOMHIAEoCzIdLkdyaWRGaWdodFBsYXllckxl";
		buffer[47] = "dmVsU3luY0luZm9IABIWCgtLQUNISkhETU5MTRjkByABKA1IABIkCgtKSUZL";
		buffer[48] = "T0hMTkhBSxj4ByABKAsyDC5DS0NLSURITU1FR0gAEj8KGGdyaWRfZmlnaHRf";
		buffer[49] = "dHV0b3JpYWxfc3luYxj+ByABKAsyGi5HcmlkRmlnaHRUdXRvcmlhbFN5bmNJ";
		buffer[50] = "bmZvSAASKQoeZ3JpZF9maWdodF9vZmZfZmllbGRfbWF4X2NvdW50GKYIIAEo";
		buffer[51] = "DUgAEigKCWxvY2tfdHlwZRjYCCABKA4yEi5HcmlkRmlnaHRMb2NrVHlwZUgA";
		buffer[52] = "EjwKFXJlbW92ZV9nYW1lX2l0ZW1faW5mbxjpCCABKAsyGi5HcmlkRmlnaHRH";
		buffer[53] = "YW1lSXRlbVN5bmNJbmZvSAASOwoUZ3JpZF9maWdodF9saW5ldXBfaHAY8ggg";
		buffer[54] = "ASgLMhouR3JpZEZpZ2h0TGluZXVwSHBTeW5jSW5mb0gAEkAKGHNlY3Rpb25f";
		buffer[55] = "cmVjb3JkX3N5bmNfaW5mbxiDCSABKAsyGy5HcmlkRmlnaHRTZWN0aW9uUmVj";
		buffer[56] = "b3JkSW5mb0gAEkEKHmdyaWRfZmlnaHRfc3luY19nYW1lX2l0ZW1faW5mbxie";
		buffer[57] = "CSABKAsyFi5HcmlkRmlnaHRHYW1lSXRlbUluZm9IABIiChdncmlkX2ZpZ2h0";
		buffer[58] = "X2J1eV9leHBfY29zdBjZCSABKA1IABI+ChV0cmFpdF90cmFja19zeW5jX2lu";
		buffer[59] = "Zm8YwQogASgLMhwuR3JpZEZpZ2h0VHJhaXRUcmFja1N5bmNJbmZvSAASJAoL";
		buffer[60] = "QkFPREhQQ09KTEgYpAsgASgLMgwuQ0tDS0lESE1NRUdIABI5ChJhZGRfZ2Ft";
		buffer[61] = "ZV9pdGVtX2luZm8Y6QsgASgLMhouR3JpZEZpZ2h0R2FtZUl0ZW1TeW5jSW5m";
		buffer[62] = "b0gAEiwKD3VwZGF0ZV9ucGNfaW5mbxjtCyABKAsyEC5HcmlkR2FtZU5wY0lu";
		buffer[63] = "Zm9IABIhChZyZW1vdmVfZm9yZ2VfdW5pcXVlX2lkGJwMIAEoDUgAEiEKFnJl";
		buffer[64] = "bW92ZV90cmFpdF9lZmZlY3RfaWQYyAwgASgNSAASJAoLR01KTEpESkRJR00Y";
		buffer[65] = "3AwgASgLMgwuSlBCQ0tDREVHT01IABIWCgtGSEhIRUJMTU9CTBj8DCABKA1I";
		buffer[66] = "ABIgChVyZW1vdmVfcm9sZV91bmlxdWVfaWQYqA0gASgNSAASQAoWZWxpdGVf";
		buffer[67] = "YnJhbmNoX3N5bmNfaW5mbxjKDSABKAsyHS5HcmlkRmlnaHRFbGl0ZUJyYW5j";
		buffer[68] = "aFN5bmNJbmZvSAASJAoLSUJDRVBDRkZNT0wYlQ4gASgLMgwuRElCSkdBS09D";
		buffer[69] = "TE9IABIkCgtQR1BLUE1PSUFJTBjCDiABKAsyDC5DTE9FUFBCQ0tHRkgAEi8K";
		buffer[70] = "DW9yYl9zeW5jX2luZm8Y5w4gASgLMhUuR3JpZEZpZ2h0T3JiU3luY0luZm9I";
		buffer[71] = "ABIVCgppdGVtX3ZhbHVlGJcPIAEoDUgAEkAKGGdyaWRfZ2FtZV9hdWdtZW50";
		buffer[72] = "X3VwZGF0ZRjKDyABKAsyGy5HcmlkRmlnaHRHYW1lQXVnbWVudFVwZGF0ZUgA";
		buffer[73] = "EjEKDnNob3Bfc3luY19pbmZvGPcPIAEoCzIWLkdyaWRGaWdodFNob3BTeW5j";
		buffer[74] = "SW5mb0gAEh8KFHJlbW92ZV9ucGNfdW5pcXVlX2lkGPgPIAEoDUgAQg0KC0tD";
		buffer[75] = "T0NDR0VPRUNPQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[29]
		{
			CKCKIDHMMEGReflection.Descriptor,
			CLOEPPBCKGFReflection.Descriptor,
			CMCJNKPKBEMReflection.Descriptor,
			DIBJGAKOCLOReflection.Descriptor,
			GridFightDamageSttInfoReflection.Descriptor,
			GridFightEliteBranchSyncInfoReflection.Descriptor,
			GridFightGameAugmentAddReflection.Descriptor,
			GridFightGameAugmentUpdateReflection.Descriptor,
			GridFightGameItemInfoReflection.Descriptor,
			GridFightGameItemSyncInfoReflection.Descriptor,
			GridFightLevelSyncInfoReflection.Descriptor,
			GridFightLineupHpSyncInfoReflection.Descriptor,
			GridFightLockInfoReflection.Descriptor,
			GridFightLockTypeReflection.Descriptor,
			GridFightOrbSyncInfoReflection.Descriptor,
			GridFightPendingActionReflection.Descriptor,
			GridFightPlayerLevelSyncInfoReflection.Descriptor,
			GridFightPortalServerDataUpdateReflection.Descriptor,
			GridFightSectionRecordInfoReflection.Descriptor,
			GridFightShopSyncInfoReflection.Descriptor,
			GridFightTraitSyncInfoReflection.Descriptor,
			GridFightTraitTrackSyncInfoReflection.Descriptor,
			GridFightTutorialSyncInfoReflection.Descriptor,
			GridGameForgeItemInfoReflection.Descriptor,
			GridGameNpcInfoReflection.Descriptor,
			GridGameOrbInfoReflection.Descriptor,
			GridGameRoleInfoReflection.Descriptor,
			JPBCKCDEGOMReflection.Descriptor,
			RoleTrackEquipmentSyncInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSyncData), GridFightSyncData.Parser, new string[55]
			{
				"CJEMKCOCECG", "RemoveOrbUniqueId", "EquipmentTrackSyncInfo", "MaxBattleRoleNum", "CFNPGNMPNDN", "AddRoleInfo", "AddNpcInfo", "HLFBBANMJDJ", "TraitSyncInfo", "PortalServerDataUpdate",
				"UpdateGameItemInfo", "AddForgeInfo", "UpdateRoleInfo", "AJIMOAMGCII", "GridFightDamageSttInfo", "GridFightComboWinNum", "SyncLockInfo", "GDPBJDHGFLB", "RemoveAugmentUniqueId", "GridFightMaxAvatarCount",
				"AugmentSyncInfo", "FinishPendingActionPos", "PendingAction", "POIPGNHONMA", "LevelSyncInfo", "GridFightMaxInterestGold", "UpdateForgeInfo", "PlayerLevel", "KACHJHDMNLM", "JIFKOHLNHAK",
				"GridFightTutorialSync", "GridFightOffFieldMaxCount", "LockType", "RemoveGameItemInfo", "GridFightLineupHp", "SectionRecordSyncInfo", "GridFightSyncGameItemInfo", "GridFightBuyExpCost", "TraitTrackSyncInfo", "BAODHPCOJLH",
				"AddGameItemInfo", "UpdateNpcInfo", "RemoveForgeUniqueId", "RemoveTraitEffectId", "GMJLJDJDIGM", "FHHHEBLMOBL", "RemoveRoleUniqueId", "EliteBranchSyncInfo", "IBCEPCFFMOL", "PGPKPMOIAIL",
				"OrbSyncInfo", "ItemValue", "GridGameAugmentUpdate", "ShopSyncInfo", "RemoveNpcUniqueId"
			}, new string[1] { "KCOCCGEOECO" }, null, null, null)
		}));
	}
}
