using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerDetailInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerDetailInfoReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 0) = "ChZQbGF5ZXJEZXRhaWxJbmZvLnByb3RvGh1EaXNwbGF5QXZhdGFyRGV0YWls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 1) = "SW5mby5wcm90bxoTSGVhZEZyYW1lSW5mby5wcm90bxoRSktGQkZHT0VCS0ku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 2) = "cHJvdG8aEUtKR01BRUdOQktMLnByb3RvGhFNTkJIRUhBTU9LTC5wcm90bxoS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 3) = "UGxhdGZvcm1UeXBlLnByb3RvGhZQbGF5ZXJPdXRmaXRJbmZvLnByb3RvGhZQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 4) = "bGF5ZXJSZWNvcmRJbmZvLnByb3RvIogFChBQbGF5ZXJEZXRhaWxJbmZvEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 5) = "C0hCSURDQUZPUE1HGAEgASgJEhEKCWhlYWRfaWNvbhgCIAEoDRImCgtyZWNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 6) = "cmRfaW5mbxgDIAEoCzIRLlBsYXllclJlY29yZEluZm8SEwoLSUNKSUdIT01E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 7) = "TkwYBCABKAkSEAoIbmlja25hbWUYBSABKAkSDQoFbGV2ZWwYBiABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 8) = "T0dKR01OQlBQTEUYByABKA0SNQoTZGlzcGxheV9hdmF0YXJfbGlzdBgIIAMo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 9) = "CzIYLkRpc3BsYXlBdmF0YXJEZXRhaWxJbmZvEhMKC09MSkZCSEtMQUpQGAkg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 10) = "ASgNEgsKA3VpZBgKIAEoDRIRCglzaWduYXR1cmUYCyABKAkSEwoLTkhJRE9B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 11) = "QU1MTkYYDCABKAgSHwoIcGxhdGZvcm0YDSABKA4yDS5QbGF0Zm9ybVR5cGUS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 12) = "EQoJaXNfYmFubmVkGA4gASgIEhMKC3dvcmxkX2xldmVsGA8gASgNEhQKC1BI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 13) = "S0FNRkZDS01MGPMCIAEoDRIsChBQbGF5ZXJPdXRmaXREYXRhGL8GIAEoCzIR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 14) = "LlBsYXllck91dGZpdEluZm8SKAoPaGVhZF9mcmFtZV9pbmZvGPQHIAEoCzIO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 15) = "LkhlYWRGcmFtZUluZm8SIgoLSklKT0lDQ0RGQ0EYjwggASgLMgwuSktGQkZH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 16) = "T0VCS0kSIgoLTENCR0ZQTUNMTk8YnAggASgLMgwuTU5CSEVIQU1PS0wSNQoS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 17) = "YXNzaXN0X2F2YXRhcl9saXN0GJEOIAMoCzIYLkRpc3BsYXlBdmF0YXJEZXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 18) = "aWxJbmZvEiIKC0dGUE1MUEdIT05HGK4PIAEoCzIMLktKR01BRUdOQktMQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 19) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray20<string>, string>(in buffer, 20))), new FileDescriptor[8]
		{
			DisplayAvatarDetailInfoReflection.Descriptor,
			HeadFrameInfoReflection.Descriptor,
			JKFBFGOEBKIReflection.Descriptor,
			KJGMAEGNBKLReflection.Descriptor,
			MNBHEHAMOKLReflection.Descriptor,
			PlatformTypeReflection.Descriptor,
			PlayerOutfitInfoReflection.Descriptor,
			PlayerRecordInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerDetailInfo), PlayerDetailInfo.Parser, new string[22]
			{
				"HBIDCAFOPMG", "HeadIcon", "RecordInfo", "ICJIGHOMDNL", "Nickname", "Level", "OGJGMNBPPLE", "DisplayAvatarList", "OLJFBHKLAJP", "Uid",
				"Signature", "NHIDOAAMLNF", "Platform", "IsBanned", "WorldLevel", "PHKAMFFCKML", "PlayerOutfitData", "HeadFrameInfo", "JIJOICCDFCA", "LCBGFPMCLNO",
				"AssistAvatarList", "GFPMLPGHONG"
			}, null, null, null, null)
		}));
	}
}
