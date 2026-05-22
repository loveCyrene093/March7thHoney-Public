using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusSelectSkillScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusSelectSkillScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5IZWxpb2J1c1NlbGVjdFNraWxsU2NSc3AucHJvdG8iPQoYSGVsaW9idXNT" + "ZWxlY3RTa2lsbFNjUnNwEhAKCHNraWxsX2lkGAggASgNEg8KB3JldGNvZGUY" + "CyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSelectSkillScRsp), HeliobusSelectSkillScRsp.Parser, new string[2] { "SkillId", "Retcode" }, null, null, null, null)
		}));
	}
}
