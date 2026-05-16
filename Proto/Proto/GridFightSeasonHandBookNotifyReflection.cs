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
		buffer[0] = "CiNHcmlkRmlnaHRTZWFzb25IYW5kQm9va05vdGlmeS5wcm90bxoiR3JpZEZp";
		buffer[1] = "Z2h0SGFuZEJvb2tBdWdtZW50SW5mby5wcm90bxogR3JpZEZpZ2h0SGFuZEJv";
		buffer[2] = "b2tFcXVpcEluZm8ucHJvdG8aIkdyaWRGaWdodEhhbmRCb29rTW9uc3Rlcklu";
		buffer[3] = "Zm8ucHJvdG8aIUdyaWRGaWdodEhhbmRCb29rUG9ydGFsSW5mby5wcm90bxof";
		buffer[4] = "R3JpZEZpZ2h0SGFuZEJvb2tSb2xlSW5mby5wcm90byKeAwodR3JpZEZpZ2h0";
		buffer[5] = "U2Vhc29uSGFuZEJvb2tOb3RpZnkSSgogaGFuZGJvb2tfZ3JpZF9maWdodF9t";
		buffer[6] = "b25zdGVyX2luZm8YxgIgASgLMh0uR3JpZEZpZ2h0SGFuZEJvb2tNb25zdGVy";
		buffer[7] = "SW5mb0gAEkoKIGhhbmRib29rX2dyaWRfZmlnaHRfYXVnbWVudF9pbmZvGIQH";
		buffer[8] = "IAEoCzIdLkdyaWRGaWdodEhhbmRCb29rQXVnbWVudEluZm9IABJECh1oYW5k";
		buffer[9] = "Ym9va19ncmlkX2ZpZ2h0X3JvbGVfaW5mbxiwByABKAsyGi5HcmlkRmlnaHRI";
		buffer[10] = "YW5kQm9va1JvbGVJbmZvSAASRgoeaGFuZGJvb2tfZ3JpZF9maWdodF9lcXVp";
		buffer[11] = "cF9pbmZvGM4MIAEoCzIbLkdyaWRGaWdodEhhbmRCb29rRXF1aXBJbmZvSAAS";
		buffer[12] = "SAofaGFuZGJvb2tfZ3JpZF9maWdodF9wb3J0YWxfaW5mbxj6DiABKAsyHC5H";
		buffer[13] = "cmlkRmlnaHRIYW5kQm9va1BvcnRhbEluZm9IAEINCgtCUElIRkFKQ0xPQ0IW";
		buffer[14] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
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
