using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleStatisticsReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleStatisticsReflection()
	{
		_003C_003Ey__InlineArray46<string> buffer = default(_003C_003Ey__InlineArray46<string>);
		buffer[0] = "ChZCYXR0bGVTdGF0aXN0aWNzLnByb3RvGhZBdmF0YXJCYXR0bGVJbmZvLnBy";
		buffer[1] = "b3RvGhFCRUdNSEVFS0dJRi5wcm90bxogQmF0dGxlQXZhdGFyR2xvYmFsQnVm";
		buffer[2] = "ZkluZm8ucHJvdG8aFUJhdHRsZUVuZFJlYXNvbi5wcm90bxobQmF0dGxlRXZl";
		buffer[3] = "bnRCYXR0bGVJbmZvLnByb3RvGiZCYXR0bGVHcmlkRmlnaHRTcGVjaWFsQmF0";
		buffer[4] = "dGxlSW5mby5wcm90bxoWQmF0dGxlVGFyZ2V0TGlzdC5wcm90bxoRQ01KQk1G";
		buffer[5] = "SENPRkkucHJvdG8aEURDRk1QTkJLS1BGLnByb3RvGhFETEZQRkZPT0hLUC5w";
		buffer[6] = "cm90bxoRRkFHQ0ZCRUJLRU8ucHJvdG8aEUZQRkZIR09LQk5LLnByb3RvGhFK";
		buffer[7] = "TkFETExJSUlGUC5wcm90bxoRS0ZLSEdMRUZES0sucHJvdG8aEUxFSENDTkdG";
		buffer[8] = "S0dNLnByb3RvGhFMRlBOREtLREVLTi5wcm90bxoRTE9DUEtETkdMS00ucHJv";
		buffer[9] = "dG8aEU1JR0pGR0pNQ0dPLnByb3RvGhdNb25zdGVyQmF0dGxlSW5mby5wcm90";
		buffer[10] = "bxoRTkpDT0ZESk5NTUwucHJvdG8aEVBQTkVHTUNJRUNFLnByb3RvGhRTdGF0";
		buffer[11] = "aXN0aWNFdmVudC5wcm90byLLCwoQQmF0dGxlU3RhdGlzdGljcxIaChJ0b3Rh";
		buffer[12] = "bF9iYXR0bGVfdHVybnMYASABKA0SGAoQdG90YWxfYXV0b190dXJucxgCIAEo";
		buffer[13] = "DRIWCg5hdmF0YXJfaWRfbGlzdBgDIAMoDRIRCgl1bHRyYV9jbnQYBCABKA0S";
		buffer[14] = "HAoUdG90YWxfZGVsYXlfY3VtdWxhdGUYBSABKAESEQoJY29zdF90aW1lGAYg";
		buffer[15] = "ASgBEi0KEmJhdHRsZV9hdmF0YXJfbGlzdBgHIAMoCzIRLkF2YXRhckJhdHRs";
		buffer[16] = "ZUluZm8SKAoMbW9uc3Rlcl9saXN0GAggAygLMhIuTW9uc3RlckJhdHRsZUlu";
		buffer[17] = "Zm8SEQoJcm91bmRfY250GAkgASgNEhgKEGNvY29vbl9kZWFkX3dhdmUYCiAB";
		buffer[18] = "KA0SGwoTYXZhdGFyX2JhdHRsZV90dXJucxgLIAEoDRIcChRtb25zdGVyX2Jh";
		buffer[19] = "dHRsZV90dXJucxgMIAEoDRI6Cg1jdXN0b21fdmFsdWVzGA0gAygLMiMuQmF0";
		buffer[20] = "dGxlU3RhdGlzdGljcy5DdXN0b21WYWx1ZXNFbnRyeRIXCg9jaGFsbGVuZ2Vf";
		buffer[21] = "c2NvcmUYDiABKA0SKwoLUE5IRURPTEhCSkwYECADKAsyFi5CYXR0bGVFdmVu";
		buffer[22] = "dEJhdHRsZUluZm8SJAoKZW5kX3JlYXNvbhgTIAEoDjIQLkJhdHRsZUVuZFJl";
		buffer[23] = "YXNvbhIhCgtPTURNSklDR0tCQhgVIAMoCzIMLk1JR0pGR0pNQ0dPEhMKC0tB";
		buffer[24] = "SURGTUVKSUZJGBYgAygFEiEKC01PQUpPUEVKT1BKGBcgAygLMgwuQ01KQk1G";
		buffer[25] = "SENPRkkSJAoLSktPQkhOUEdNSEMYGiADKAsyDy5TdGF0aXN0aWNFdmVudBIh";
		buffer[26] = "CgtOSERERkNBSUVHRBgbIAMoCzIMLkRMRlBGRk9PSEtQEkMKEmJhdHRsZV90";
		buffer[27] = "YXJnZXRfaW5mbxgcIAMoCzInLkJhdHRsZVN0YXRpc3RpY3MuQmF0dGxlVGFy";
		buffer[28] = "Z2V0SW5mb0VudHJ5EiEKC0RERENGQ0FBSkhDGB0gAygLMgwuTkpDT0ZESk5N";
		buffer[29] = "TUwSNgoLRk1DSlBQSUxQTEwYHiABKAsyIS5CYXR0bGVHcmlkRmlnaHRTcGVj";
		buffer[30] = "aWFsQmF0dGxlSW5mbxIhCgtDT0lHR1BDUExIRxgfIAEoCzIMLkZBR0NGQkVC";
		buffer[31] = "S0VPEhMKC05BSlBNR0ZKS0VPGCAgASgIEiEKC0hPQk5IQkNKSURNGCEgAygL";
		buffer[32] = "MgwuTE9DUEtETkdMS00SIQoLS0tKSEdJQUFES08YIiADKAsyDC5CRUdNSEVF";
		buffer[33] = "S0dJRhITCgtKRkdMTklPRUVITBgjIAEoDRIhCgtCS0dCQUVHUExNTRgkIAEo";
		buffer[34] = "CzIMLkRDRk1QTkJLS1BGEiEKC01FRkdER0ZMRk1EGCUgASgLMgwuTEZQTkRL";
		buffer[35] = "S0RFS04SIQoLTkxBSk9NQk5ITkEYJiABKAsyDC5KTkFETExJSUlGUBIhCgtD";
		buffer[36] = "RUFJSk9QR0JBTRgnIAEoCzIMLkZQRkZIR09LQk5LEiEKC0pQRU9DSUNHUERP";
		buffer[37] = "GCggASgLMgwuS0ZLSEdMRUZES0sSEwoLS0dLRkFEREVHTkoYKSABKA0SMAoL";
		buffer[38] = "SUtFSURISE1GT08YKiADKAsyGy5CYXR0bGVBdmF0YXJHbG9iYWxCdWZmSW5m";
		buffer[39] = "bxIhCgtPR1BPRk1PR1BJUBgrIAEoCzIMLkxFSENDTkdGS0dNEhMKC0xGSEVK";
		buffer[40] = "RERIRk5EGCwgAygNEhMKC0FOTUJBSUZPQkpQGC0gAygNEiEKC0lQS0ZNRkRP";
		buffer[41] = "UEdOGC4gASgLMgwuUFBORUdNQ0lFQ0UaMwoRQ3VzdG9tVmFsdWVzRW50cnkS";
		buffer[42] = "CwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgCOgI4ARpKChVCYXR0bGVUYXJn";
		buffer[43] = "ZXRJbmZvRW50cnkSCwoDa2V5GAEgASgNEiAKBXZhbHVlGAIgASgLMhEuQmF0";
		buffer[44] = "dGxlVGFyZ2V0TGlzdDoCOAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[45] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[22]
		{
			AvatarBattleInfoReflection.Descriptor,
			BEGMHEEKGIFReflection.Descriptor,
			BattleAvatarGlobalBuffInfoReflection.Descriptor,
			BattleEndReasonReflection.Descriptor,
			BattleEventBattleInfoReflection.Descriptor,
			BattleGridFightSpecialBattleInfoReflection.Descriptor,
			BattleTargetListReflection.Descriptor,
			CMJBMFHCOFIReflection.Descriptor,
			DCFMPNBKKPFReflection.Descriptor,
			DLFPFFOOHKPReflection.Descriptor,
			FAGCFBEBKEOReflection.Descriptor,
			FPFFHGOKBNKReflection.Descriptor,
			JNADLLIIIFPReflection.Descriptor,
			KFKHGLEFDKKReflection.Descriptor,
			LEHCCNGFKGMReflection.Descriptor,
			LFPNDKKDEKNReflection.Descriptor,
			LOCPKDNGLKMReflection.Descriptor,
			MIGJFGJMCGOReflection.Descriptor,
			MonsterBattleInfoReflection.Descriptor,
			NJCOFDJNMMLReflection.Descriptor,
			PPNEGMCIECEReflection.Descriptor,
			StatisticEventReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleStatistics), BattleStatistics.Parser, new string[40]
			{
				"TotalBattleTurns", "TotalAutoTurns", "AvatarIdList", "UltraCnt", "TotalDelayCumulate", "CostTime", "BattleAvatarList", "MonsterList", "RoundCnt", "CocoonDeadWave",
				"AvatarBattleTurns", "MonsterBattleTurns", "CustomValues", "ChallengeScore", "PNHEDOLHBJL", "EndReason", "OMDMJICGKBB", "KAIDFMEJIFI", "MOAJOPEJOPJ", "JKOBHNPGMHC",
				"NHDDFCAIEGD", "BattleTargetInfo", "DDDCFCAAJHC", "FMCJPPILPLL", "COIGGPCPLHG", "NAJPMGFJKEO", "HOBNHBCJIDM", "KKJHGIAADKO", "JFGLNIOEEHL", "BKGBAEGPLMM",
				"MEFGDGFLFMD", "NLAJOMBNHNA", "CEAIJOPGBAM", "JPEOCICGPDO", "KGKFADDEGNJ", "IKEIDHHMFOO", "OGPOFMOGPIP", "LFHEJDDHFND", "ANMBAIFOBJP", "IPKFMFDOPGN"
			}, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
