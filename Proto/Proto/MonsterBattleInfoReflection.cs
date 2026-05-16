using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonsterBattleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonsterBattleInfoReflection()
	{
		_003C_003Ey__InlineArray23<string> buffer = default(_003C_003Ey__InlineArray23<string>);
		buffer[0] = "ChdNb25zdGVyQmF0dGxlSW5mby5wcm90bxoRQU1CRklFS0RDRUwucHJvdG8a";
		buffer[1] = "GkF0dGFja0RhbWFnZVByb3BlcnR5LnByb3RvGhFGQktCT0tIQ0xMRi5wcm90";
		buffer[2] = "bxoRTEVQRExMSkhJUEwucHJvdG8aEU9GS0hJSEZCTkZHLnByb3RvGhFQR1BF";
		buffer[3] = "TE5GS09NRC5wcm90bxoRUExETUdHQlBIUEIucHJvdG8aFlNraWxsVXNlUHJv";
		buffer[4] = "cGVydHkucHJvdG8imwYKEU1vbnN0ZXJCYXR0bGVJbmZvEhEKCWVudGl0eV9p";
		buffer[5] = "ZBgBIAEoDRISCgptb25zdGVyX2lkGAIgASgNEhMKC01OQkxIS0tNUE5QGAMg";
		buffer[6] = "ASgNEhMKC0hQSk5KR0lPSERIGAQgASgNEiEKC1BMQ0hPS0xGTUZHGAUgASgL";
		buffer[7] = "MgwuQU1CRklFS0RDRUwSEwoLdG90YWxfdHVybnMYBiABKA0SFAoMdG90YWxf";
		buffer[8] = "ZGFtYWdlGAcgASgBEhIKCnRvdGFsX2hlYWwYCCABKAESGgoSdG90YWxfZGFt";
		buffer[9] = "YWdlX3Rha2VuGAkgASgBEhMKC0hHUExCT0NQQUVHGAogASgBEhgKEHRvdGFs";
		buffer[10] = "X2hwX3JlY292ZXIYCyABKAESEAoIc3RhZ2VfaWQYDCABKA0SEQoJYmF0dGxl";
		buffer[11] = "X2lkGA0gASgNEhMKC0tFSURBQ0pGRkZDGA4gASgNEjEKEmF0dGFja190eXBl";
		buffer[12] = "X2RhbWFnZRgPIAMoCzIVLkF0dGFja0RhbWFnZVByb3BlcnR5EiYKC3NraWxs";
		buffer[13] = "X3RpbWVzGBAgAygLMhEuU2tpbGxVc2VQcm9wZXJ0eRISCgpzdGFnZV90eXBl";
		buffer[14] = "GBEgASgNEhMKC0pPSkZOQU1NQk1FGBIgASgBEhYKDmRlbGF5X2N1bXVsYXRl";
		buffer[15] = "GBMgASgBEiEKC0dPTUVDUERBS0ZOGBQgASgOMgwuRkJLQk9LSENMTEYSDAoE";
		buffer[16] = "d2F2ZRgVIAEoDRITCgtDSEJLR0dPQUNFQhgWIAEoBRINCgVwaGFzZRgXIAEo";
		buffer[17] = "DRITCgtQTUNOTkVDQ0NQTBgYIAEoDRIhCgtNSEZNQUVMRlBMRBgZIAEoDjIM";
		buffer[18] = "Lk9GS0hJSEZCTkZHEiAKCnNraWxsX2luZm8YGiADKAsyDC5QTERNR0dCUEhQ";
		buffer[19] = "QhITCgtHS0RHRkxDT0hPQRgbIAEoDRIhCgtJR0FGTENLSkpLTRgcIAMoCzIM";
		buffer[20] = "LlBHUEVMTkZLT01EEhMKC0lPR0NER0xGTENCGB0gASgNEhMKC09GSExORlBN";
		buffer[21] = "UEhIGB4gASgNEiEKC0dKQ0tHTExFR0FFGB8gASgOMgwuTEVQRExMSkhJUExC";
		buffer[22] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[8]
		{
			AMBFIEKDCELReflection.Descriptor,
			AttackDamagePropertyReflection.Descriptor,
			FBKBOKHCLLFReflection.Descriptor,
			LEPDLLJHIPLReflection.Descriptor,
			OFKHIHFBNFGReflection.Descriptor,
			PGPELNFKOMDReflection.Descriptor,
			PLDMGGBPHPBReflection.Descriptor,
			SkillUsePropertyReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonsterBattleInfo), MonsterBattleInfo.Parser, new string[31]
			{
				"EntityId", "MonsterId", "MNBLHKKMPNP", "HPJNJGIOHDH", "PLCHOKLFMFG", "TotalTurns", "TotalDamage", "TotalHeal", "TotalDamageTaken", "HGPLBOCPAEG",
				"TotalHpRecover", "StageId", "BattleId", "KEIDACJFFFC", "AttackTypeDamage", "SkillTimes", "StageType", "JOJFNAMMBME", "DelayCumulate", "GOMECPDAKFN",
				"Wave", "CHBKGGOACEB", "Phase", "PMCNNECCCPL", "MHFMAELFPLD", "SkillInfo", "GKDGFLCOHOA", "IGAFLCKJJKM", "IOGCDGLFLCB", "OFHLNFPMPHH",
				"GJCKGLLEGAE"
			}, null, null, null, null)
		}));
	}
}
