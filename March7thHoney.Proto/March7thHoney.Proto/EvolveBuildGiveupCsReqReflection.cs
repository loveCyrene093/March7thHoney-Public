using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildGiveupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildGiveupCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxFdm9sdmVCdWlsZEdpdmV1cENzUmVxLnByb3RvIioKFkV2b2x2ZUJ1aWxk" + "R2l2ZXVwQ3NSZXESEAoIbGV2ZWxfaWQYDCABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildGiveupCsReq), EvolveBuildGiveupCsReq.Parser, new string[1] { "LevelId" }, null, null, null, null)
		}));
	}
}
