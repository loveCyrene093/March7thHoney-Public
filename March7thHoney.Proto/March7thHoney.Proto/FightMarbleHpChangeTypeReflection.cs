using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightMarbleHpChangeTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightMarbleHpChangeTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1GaWdodE1hcmJsZUhwQ2hhbmdlVHlwZS5wcm90bypwChdGaWdodE1hcmJs" + "ZUhwQ2hhbmdlVHlwZRIbChdBR0hMSEFGSUFFSl9PUFBFT0VLTERDShAAEhsK" + "F0FHSExIQUZJQUVKX0NCSEdPTUhOTE1JEAESGwoXQUdITEhBRklBRUpfRE5P" + "T1BBTURBQ0MQAkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FightMarbleHpChangeType) }, null, null));
	}
}
