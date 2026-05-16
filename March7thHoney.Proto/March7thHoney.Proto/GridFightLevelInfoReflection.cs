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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 0) = "ChhHcmlkRmlnaHRMZXZlbEluZm8ucHJvdG8aEURESklPRk9OS01FLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 1) = "GhFESUJKR0FLT0NMTy5wcm90bxoXR3JpZEZpZ2h0Qm9zc0luZm8ucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 2) = "IUdyaWRGaWdodEdhbWVQb3J0YWxCdWZmSW5mby5wcm90bxoYR3JpZEZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 3) = "TGF5ZXJJbmZvLnByb3RvGhFJS0ZFREZCTE9PRy5wcm90bxoRT1BCQ0NPTFBE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 4) = "UEMucHJvdG8imwMKEkdyaWRGaWdodExldmVsSW5mbxIdChVncmlkX2ZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 5) = "X2FmZml4X2xpc3QYASADKA0SJQoJYm9zc19pbmZvGAIgASgLMhIuR3JpZEZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 6) = "Z2h0Qm9zc0luZm8SEwoLRENQS1BOTEtHTU0YAyABKA0SIQoLSEdBSE1JUElC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 7) = "TE8YBCADKAsyDC5PUEJDQ09MUERQQxIhCgtDTUhCRE1PSkpFThgFIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 8) = "LklLRkVERkJMT09HEiEKC0VDQ0dKRE1PR0FOGAYgASgLMgwuRERKSU9GT05L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 9) = "TUUSQQobZ3JpZF9maWdodF9wb3J0YWxfYnVmZl9saXN0GAcgAygLMhwuR3Jp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 10) = "ZEZpZ2h0R2FtZVBvcnRhbEJ1ZmZJbmZvEhIKCnNlY3Rpb25faWQYCSABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 11) = "IQoLSUFLRlBNT0VKTEYYCyADKAsyDC5ESUJKR0FLT0NMTxIyChVncmlkX2Zp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 12) = "Z2h0X2xheWVyX2luZm8YDCABKAsyEy5HcmlkRmlnaHRMYXllckluZm8SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 13) = "TkRPQ0lLUExLSUYYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 14) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray15<string>, string>(in buffer, 15))), new FileDescriptor[7]
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
