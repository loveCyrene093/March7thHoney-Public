using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightHandBookInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightHandBookInfoReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		buffer[0] = "ChtHcmlkRmlnaHRIYW5kQm9va0luZm8ucHJvdG8aIkdyaWRGaWdodEhhbmRC";
		buffer[1] = "b29rQXVnbWVudEluZm8ucHJvdG8aIEdyaWRGaWdodEhhbmRCb29rRXF1aXBJ";
		buffer[2] = "bmZvLnByb3RvGiJHcmlkRmlnaHRIYW5kQm9va01vbnN0ZXJJbmZvLnByb3Rv";
		buffer[3] = "GiFHcmlkRmlnaHRIYW5kQm9va1BvcnRhbEluZm8ucHJvdG8aH0dyaWRGaWdo";
		buffer[4] = "dEhhbmRCb29rUm9sZUluZm8ucHJvdG8iywIKFUdyaWRGaWdodEhhbmRCb29r";
		buffer[5] = "SW5mbxI+ChdncmlkX2ZpZ2h0X21vbnN0ZXJfaW5mbxgCIAEoCzIdLkdyaWRG";
		buffer[6] = "aWdodEhhbmRCb29rTW9uc3RlckluZm8SOAoUZ3JpZF9maWdodF9yb2xlX2lu";
		buffer[7] = "Zm8YBCABKAsyGi5HcmlkRmlnaHRIYW5kQm9va1JvbGVJbmZvEjwKFmdyaWRf";
		buffer[8] = "ZmlnaHRfcG9ydGFsX2luZm8YBSABKAsyHC5HcmlkRmlnaHRIYW5kQm9va1Bv";
		buffer[9] = "cnRhbEluZm8SOgoVZ3JpZF9maWdodF9lcXVpcF9pbmZvGAcgASgLMhsuR3Jp";
		buffer[10] = "ZEZpZ2h0SGFuZEJvb2tFcXVpcEluZm8SPgoXZ3JpZF9maWdodF9hdWdtZW50";
		buffer[11] = "X2luZm8YCSABKAsyHS5HcmlkRmlnaHRIYW5kQm9va0F1Z21lbnRJbmZvQhaq";
		buffer[12] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			GridFightHandBookAugmentInfoReflection.Descriptor,
			GridFightHandBookEquipInfoReflection.Descriptor,
			GridFightHandBookMonsterInfoReflection.Descriptor,
			GridFightHandBookPortalInfoReflection.Descriptor,
			GridFightHandBookRoleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightHandBookInfo), GridFightHandBookInfo.Parser, new string[5] { "GridFightMonsterInfo", "GridFightRoleInfo", "GridFightPortalInfo", "GridFightEquipInfo", "GridFightAugmentInfo" }, null, null, null, null)
		}));
	}
}
