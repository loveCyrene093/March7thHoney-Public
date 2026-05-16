using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossInfoReflection()
	{
		_003C_003Ey__InlineArray18<string> buffer = default(_003C_003Ey__InlineArray18<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 0) = "ChdDaGFsbGVuZ2VCb3NzSW5mby5wcm90bxoiQ2hhbGxlbmdlQm9zc0F2YXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 1) = "clJlbGljSW5mby5wcm90bxogQ2hhbGxlbmdlQm9zc0VxdWlwbWVudEluZm8u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 2) = "cHJvdG8aIUNoYWxsZW5nZUJvc3NTaW5nbGVOb2RlSW5mby5wcm90bxoRRUVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 3) = "UEhKQ05CRk8ucHJvdG8i6wQKEUNoYWxsZW5nZUJvc3NJbmZvEjEKC3NlY29u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 4) = "ZF9ub2RlGAIgASgLMhwuQ2hhbGxlbmdlQm9zc1NpbmdsZU5vZGVJbmZvEiEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 5) = "C0FCTkRGS0ZJS0NJGAQgAygLMgwuRUVCUEhKQ05CRk8SUwoaY2hhbGxlbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 6) = "X2F2YXRhcl9yZWxpY19tYXAYBSADKAsyLy5DaGFsbGVuZ2VCb3NzSW5mby5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 7) = "aGFsbGVuZ2VBdmF0YXJSZWxpY01hcEVudHJ5EhQKDGZpcnN0X2xpbmV1cBgG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 8) = "IAMoDRJbCh5jaGFsbGVuZ2VfYXZhdGFyX2VxdWlwbWVudF9tYXAYByADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 9) = "My5DaGFsbGVuZ2VCb3NzSW5mby5DaGFsbGVuZ2VBdmF0YXJFcXVpcG1lbnRN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 10) = "YXBFbnRyeRIhCgtCS05LTEVPQ0pOTxgKIAMoCzIMLkVFQlBISkNOQkZPEjAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 11) = "CmZpcnN0X25vZGUYCyABKAsyHC5DaGFsbGVuZ2VCb3NzU2luZ2xlTm9kZUlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 12) = "Zm8SFQoNc2Vjb25kX2xpbmV1cBgNIAMoDRIMCgR1bmsxGA8gASgIGl0KHENo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 13) = "YWxsZW5nZUF2YXRhclJlbGljTWFwRW50cnkSCwoDa2V5GAEgASgNEiwKBXZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 14) = "bHVlGAIgASgLMh0uQ2hhbGxlbmdlQm9zc0F2YXRhclJlbGljSW5mbzoCOAEa";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 15) = "XwogQ2hhbGxlbmdlQXZhdGFyRXF1aXBtZW50TWFwRW50cnkSCwoDa2V5GAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 16) = "ASgNEioKBXZhbHVlGAIgASgLMhsuQ2hhbGxlbmdlQm9zc0VxdWlwbWVudElu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 17) = "Zm86AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray18<string>, string>(in buffer, 18))), new FileDescriptor[4]
		{
			ChallengeBossAvatarRelicInfoReflection.Descriptor,
			ChallengeBossEquipmentInfoReflection.Descriptor,
			ChallengeBossSingleNodeInfoReflection.Descriptor,
			EEBPHJCNBFOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossInfo), ChallengeBossInfo.Parser, new string[9] { "SecondNode", "ABNDFKFIKCI", "ChallengeAvatarRelicMap", "FirstLineup", "ChallengeAvatarEquipmentMap", "BKNKLEOCJNO", "FirstNode", "SecondLineup", "Unk1" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
