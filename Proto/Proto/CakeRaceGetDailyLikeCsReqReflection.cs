using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceGetDailyLikeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceGetDailyLikeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DYWtlUmFjZUdldERhaWx5TGlrZUNzUmVxLnByb3RvIhsKGUNha2VSYWNl" + "R2V0RGFpbHlMaWtlQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceGetDailyLikeCsReq), CakeRaceGetDailyLikeCsReq.Parser, null, null, null, null, null)
		}));
	}
}
