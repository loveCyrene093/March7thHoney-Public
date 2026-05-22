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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 0) = "ChZCYXR0bGVTdGF0aXN0aWNzLnByb3RvGhZBdmF0YXJCYXR0bGVJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 1) = "b3RvGhFCRUdNSEVFS0dJRi5wcm90bxogQmF0dGxlQXZhdGFyR2xvYmFsQnVm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 2) = "ZkluZm8ucHJvdG8aFUJhdHRsZUVuZFJlYXNvbi5wcm90bxobQmF0dGxlRXZl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 3) = "bnRCYXR0bGVJbmZvLnByb3RvGiZCYXR0bGVHcmlkRmlnaHRTcGVjaWFsQmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 4) = "dGxlSW5mby5wcm90bxoWQmF0dGxlVGFyZ2V0TGlzdC5wcm90bxoRQ01KQk1G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 5) = "SENPRkkucHJvdG8aEURDRk1QTkJLS1BGLnByb3RvGhFETEZQRkZPT0hLUC5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 6) = "cm90bxoRRkFHQ0ZCRUJLRU8ucHJvdG8aEUZQRkZIR09LQk5LLnByb3RvGhFK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 7) = "TkFETExJSUlGUC5wcm90bxoRS0ZLSEdMRUZES0sucHJvdG8aEUxFSENDTkdG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 8) = "S0dNLnByb3RvGhFMRlBOREtLREVLTi5wcm90bxoRTE9DUEtETkdMS00ucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 9) = "dG8aEU1JR0pGR0pNQ0dPLnByb3RvGhdNb25zdGVyQmF0dGxlSW5mby5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 10) = "bxoRTkpDT0ZESk5NTUwucHJvdG8aEVBQTkVHTUNJRUNFLnByb3RvGhRTdGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 11) = "aXN0aWNFdmVudC5wcm90byLLCwoQQmF0dGxlU3RhdGlzdGljcxIaChJ0b3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 12) = "bF9iYXR0bGVfdHVybnMYASABKA0SGAoQdG90YWxfYXV0b190dXJucxgCIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 13) = "DRIWCg5hdmF0YXJfaWRfbGlzdBgDIAMoDRIRCgl1bHRyYV9jbnQYBCABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 14) = "HAoUdG90YWxfZGVsYXlfY3VtdWxhdGUYBSABKAESEQoJY29zdF90aW1lGAYg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 15) = "ASgBEi0KEmJhdHRsZV9hdmF0YXJfbGlzdBgHIAMoCzIRLkF2YXRhckJhdHRs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 16) = "ZUluZm8SKAoMbW9uc3Rlcl9saXN0GAggAygLMhIuTW9uc3RlckJhdHRsZUlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 17) = "Zm8SEQoJcm91bmRfY250GAkgASgNEhgKEGNvY29vbl9kZWFkX3dhdmUYCiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 18) = "KA0SGwoTYXZhdGFyX2JhdHRsZV90dXJucxgLIAEoDRIcChRtb25zdGVyX2Jh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 19) = "dHRsZV90dXJucxgMIAEoDRI6Cg1jdXN0b21fdmFsdWVzGA0gAygLMiMuQmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 20) = "dGxlU3RhdGlzdGljcy5DdXN0b21WYWx1ZXNFbnRyeRIXCg9jaGFsbGVuZ2Vf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 21) = "c2NvcmUYDiABKA0SKwoLUE5IRURPTEhCSkwYECADKAsyFi5CYXR0bGVFdmVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 22) = "dEJhdHRsZUluZm8SJAoKZW5kX3JlYXNvbhgTIAEoDjIQLkJhdHRsZUVuZFJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 23) = "YXNvbhIhCgtPTURNSklDR0tCQhgVIAMoCzIMLk1JR0pGR0pNQ0dPEhMKC0tB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 24) = "SURGTUVKSUZJGBYgAygFEiEKC01PQUpPUEVKT1BKGBcgAygLMgwuQ01KQk1G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 25) = "SENPRkkSJAoLSktPQkhOUEdNSEMYGiADKAsyDy5TdGF0aXN0aWNFdmVudBIh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 26) = "CgtOSERERkNBSUVHRBgbIAMoCzIMLkRMRlBGRk9PSEtQEkMKEmJhdHRsZV90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 27) = "YXJnZXRfaW5mbxgcIAMoCzInLkJhdHRsZVN0YXRpc3RpY3MuQmF0dGxlVGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 28) = "Z2V0SW5mb0VudHJ5EiEKC0RERENGQ0FBSkhDGB0gAygLMgwuTkpDT0ZESk5N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 29) = "TUwSNgoLRk1DSlBQSUxQTEwYHiABKAsyIS5CYXR0bGVHcmlkRmlnaHRTcGVj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 30) = "aWFsQmF0dGxlSW5mbxIhCgtDT0lHR1BDUExIRxgfIAEoCzIMLkZBR0NGQkVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 31) = "S0VPEhMKC05BSlBNR0ZKS0VPGCAgASgIEiEKC0hPQk5IQkNKSURNGCEgAygL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 32) = "MgwuTE9DUEtETkdMS00SIQoLS0tKSEdJQUFES08YIiADKAsyDC5CRUdNSEVF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 33) = "S0dJRhITCgtKRkdMTklPRUVITBgjIAEoDRIhCgtCS0dCQUVHUExNTRgkIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 34) = "CzIMLkRDRk1QTkJLS1BGEiEKC01FRkdER0ZMRk1EGCUgASgLMgwuTEZQTkRL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 35) = "S0RFS04SIQoLTkxBSk9NQk5ITkEYJiABKAsyDC5KTkFETExJSUlGUBIhCgtD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 36) = "RUFJSk9QR0JBTRgnIAEoCzIMLkZQRkZIR09LQk5LEiEKC0pQRU9DSUNHUERP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 37) = "GCggASgLMgwuS0ZLSEdMRUZES0sSEwoLS0dLRkFEREVHTkoYKSABKA0SMAoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 38) = "SUtFSURISE1GT08YKiADKAsyGy5CYXR0bGVBdmF0YXJHbG9iYWxCdWZmSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 39) = "bxIhCgtPR1BPRk1PR1BJUBgrIAEoCzIMLkxFSENDTkdGS0dNEhMKC0xGSEVK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 40) = "RERIRk5EGCwgAygNEhMKC0FOTUJBSUZPQkpQGC0gAygNEiEKC0lQS0ZNRkRP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 41) = "UEdOGC4gASgLMgwuUFBORUdNQ0lFQ0UaMwoRQ3VzdG9tVmFsdWVzRW50cnkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 42) = "CwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgCOgI4ARpKChVCYXR0bGVUYXJn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 43) = "ZXRJbmZvRW50cnkSCwoDa2V5GAEgASgNEiAKBXZhbHVlGAIgASgLMhEuQmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 44) = "dGxlVGFyZ2V0TGlzdDoCOAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray46<string>, string>(ref buffer, 45) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray46<string>, string>(in buffer, 46))), new FileDescriptor[22]
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
