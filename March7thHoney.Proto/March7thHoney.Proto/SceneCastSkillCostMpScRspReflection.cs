using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneCastSkillCostMpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneCastSkillCostMpScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TY2VuZUNhc3RTa2lsbENvc3RNcFNjUnNwLnByb3RvIkQKGVNjZW5lQ2Fz" + "dFNraWxsQ29zdE1wU2NSc3ASFgoOY2FzdF9lbnRpdHlfaWQYCCABKA0SDwoH" + "cmV0Y29kZRgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneCastSkillCostMpScRsp), SceneCastSkillCostMpScRsp.Parser, new string[2] { "CastEntityId", "Retcode" }, null, null, null, null)
		}));
	}
}
