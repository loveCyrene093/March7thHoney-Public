using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightLevelInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightLevelInfoReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		buffer[0] = "ChhHcmlkRmlnaHRMZXZlbEluZm8ucHJvdG8aEURESklPRk9OS01FLnByb3Rv";
		buffer[1] = "GhFESUJKR0FLT0NMTy5wcm90bxoXR3JpZEZpZ2h0Qm9zc0luZm8ucHJvdG8a";
		buffer[2] = "IUdyaWRGaWdodEdhbWVQb3J0YWxCdWZmSW5mby5wcm90bxoYR3JpZEZpZ2h0";
		buffer[3] = "TGF5ZXJJbmZvLnByb3RvGhFJS0ZFREZCTE9PRy5wcm90bxoRT1BCQ0NPTFBE";
		buffer[4] = "UEMucHJvdG8imwMKEkdyaWRGaWdodExldmVsSW5mbxIdChVncmlkX2ZpZ2h0";
		buffer[5] = "X2FmZml4X2xpc3QYASADKA0SJQoJYm9zc19pbmZvGAIgASgLMhIuR3JpZEZp";
		buffer[6] = "Z2h0Qm9zc0luZm8SEwoLRENQS1BOTEtHTU0YAyABKA0SIQoLSEdBSE1JUElC";
		buffer[7] = "TE8YBCADKAsyDC5PUEJDQ09MUERQQxIhCgtDTUhCRE1PSkpFThgFIAEoCzIM";
		buffer[8] = "LklLRkVERkJMT09HEiEKC0VDQ0dKRE1PR0FOGAYgASgLMgwuRERKSU9GT05L";
		buffer[9] = "TUUSQQobZ3JpZF9maWdodF9wb3J0YWxfYnVmZl9saXN0GAcgAygLMhwuR3Jp";
		buffer[10] = "ZEZpZ2h0R2FtZVBvcnRhbEJ1ZmZJbmZvEhIKCnNlY3Rpb25faWQYCSABKA0S";
		buffer[11] = "IQoLSUFLRlBNT0VKTEYYCyADKAsyDC5ESUJKR0FLT0NMTxIyChVncmlkX2Zp";
		buffer[12] = "Z2h0X2xheWVyX2luZm8YDCABKAsyEy5HcmlkRmlnaHRMYXllckluZm8SEwoL";
		buffer[13] = "TkRPQ0lLUExLSUYYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[14] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[7]
		{
			DDJIOFONKMEReflection.Descriptor,
			DIBJGAKOCLOReflection.Descriptor,
			GridFightBossInfoReflection.Descriptor,
			GridFightGamePortalBuffInfoReflection.Descriptor,
			GridFightLayerInfoReflection.Descriptor,
			IKFEDFBLOOGReflection.Descriptor,
			OPBCCOLPDPCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightLevelInfo), GridFightLevelInfo.Parser, new string[11]
			{
				"GridFightAffixList", "BossInfo", "DCPKPNLKGMM", "HGAHMIPIBLO", "CMHBDMOJJEN", "ECCGJDMOGAN", "GridFightPortalBuffList", "SectionId", "IAKFPMOEJLF", "GridFightLayerInfo",
				"NDOCIKPLKIF"
			}, null, null, null, null)
		}));
	}
}
