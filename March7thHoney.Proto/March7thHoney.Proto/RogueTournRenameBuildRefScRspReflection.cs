using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournRenameBuildRefScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournRenameBuildRefScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSb2d1ZVRvdXJuUmVuYW1lQnVpbGRSZWZTY1JzcC5wcm90byJTCh1Sb2d1" + "ZVRvdXJuUmVuYW1lQnVpbGRSZWZTY1JzcBITCgtLS0dJRUVOQ09JQxgDIAEo" + "DRIPCgdyZXRjb2RlGAogASgNEgwKBG5hbWUYCyABKAlCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournRenameBuildRefScRsp), RogueTournRenameBuildRefScRsp.Parser, new string[3] { "KKGIEENCOIC", "Retcode", "Name" }, null, null, null, null)
		}));
	}
}
