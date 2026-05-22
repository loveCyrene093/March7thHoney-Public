using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSeasonHandBookNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSeasonHandBookNotifyReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 0) = "CiNHcmlkRmlnaHRTZWFzb25IYW5kQm9va05vdGlmeS5wcm90bxoiR3JpZEZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 1) = "Z2h0SGFuZEJvb2tBdWdtZW50SW5mby5wcm90bxogR3JpZEZpZ2h0SGFuZEJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 2) = "b2tFcXVpcEluZm8ucHJvdG8aIkdyaWRGaWdodEhhbmRCb29rTW9uc3Rlcklu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 3) = "Zm8ucHJvdG8aIUdyaWRGaWdodEhhbmRCb29rUG9ydGFsSW5mby5wcm90bxof";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 4) = "R3JpZEZpZ2h0SGFuZEJvb2tSb2xlSW5mby5wcm90byKeAwodR3JpZEZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 5) = "U2Vhc29uSGFuZEJvb2tOb3RpZnkSSgogaGFuZGJvb2tfZ3JpZF9maWdodF9t";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 6) = "b25zdGVyX2luZm8YxgIgASgLMh0uR3JpZEZpZ2h0SGFuZEJvb2tNb25zdGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 7) = "SW5mb0gAEkoKIGhhbmRib29rX2dyaWRfZmlnaHRfYXVnbWVudF9pbmZvGIQH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 8) = "IAEoCzIdLkdyaWRGaWdodEhhbmRCb29rQXVnbWVudEluZm9IABJECh1oYW5k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 9) = "Ym9va19ncmlkX2ZpZ2h0X3JvbGVfaW5mbxiwByABKAsyGi5HcmlkRmlnaHRI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 10) = "YW5kQm9va1JvbGVJbmZvSAASRgoeaGFuZGJvb2tfZ3JpZF9maWdodF9lcXVp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 11) = "cF9pbmZvGM4MIAEoCzIbLkdyaWRGaWdodEhhbmRCb29rRXF1aXBJbmZvSAAS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 12) = "SAofaGFuZGJvb2tfZ3JpZF9maWdodF9wb3J0YWxfaW5mbxj6DiABKAsyHC5H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 13) = "cmlkRmlnaHRIYW5kQm9va1BvcnRhbEluZm9IAEINCgtCUElIRkFKQ0xPQ0IW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 14) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray15<string>, string>(in buffer, 15))), new FileDescriptor[5]
		{
			GridFightHandBookAugmentInfoReflection.Descriptor,
			GridFightHandBookEquipInfoReflection.Descriptor,
			GridFightHandBookMonsterInfoReflection.Descriptor,
			GridFightHandBookPortalInfoReflection.Descriptor,
			GridFightHandBookRoleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSeasonHandBookNotify), GridFightSeasonHandBookNotify.Parser, new string[5] { "HandbookGridFightMonsterInfo", "HandbookGridFightAugmentInfo", "HandbookGridFightRoleInfo", "HandbookGridFightEquipInfo", "HandbookGridFightPortalInfo" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
