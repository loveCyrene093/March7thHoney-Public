using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FarmStageGachaInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FarmStageGachaInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGYXJtU3RhZ2VHYWNoYUluZm8ucHJvdG8iTAoSRmFybVN0YWdlR2FjaGFJ" + "bmZvEhAKCGdhY2hhX2lkGAQgASgNEhIKCmJlZ2luX3RpbWUYCCABKAMSEAoI" + "ZW5kX3RpbWUYCyABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FarmStageGachaInfo), FarmStageGachaInfo.Parser, new string[3] { "GachaId", "BeginTime", "EndTime" }, null, null, null, null)
		}));
	}
}
