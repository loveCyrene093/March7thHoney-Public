using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KNHGHPACBMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KNHGHPACBMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTkhHSFBBQ0JNQy5wcm90bxoaR3JpZEZpZ2h0Q3VycmVudEluZm8ucHJv" + "dG8iUQoLS05IR0hQQUNCTUMSDwoHcmV0Y29kZRgCIAEoDRIxChJmaWdodF9j" + "dXJyZW50X2luZm8YCiABKAsyFS5HcmlkRmlnaHRDdXJyZW50SW5mb0IWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GridFightCurrentInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KNHGHPACBMC), KNHGHPACBMC.Parser, new string[2] { "Retcode", "FightCurrentInfo" }, null, null, null, null)
		}));
	}
}
