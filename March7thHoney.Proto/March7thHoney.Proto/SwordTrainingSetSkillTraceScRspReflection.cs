using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingSetSkillTraceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingSetSkillTraceScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVTd29yZFRyYWluaW5nU2V0U2tpbGxUcmFjZVNjUnNwLnByb3RvIkQKH1N3" + "b3JkVHJhaW5pbmdTZXRTa2lsbFRyYWNlU2NSc3ASEAoIc2tpbGxfaWQYCSAB" + "KA0SDwoHcmV0Y29kZRgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingSetSkillTraceScRsp), SwordTrainingSetSkillTraceScRsp.Parser, new string[2] { "SkillId", "Retcode" }, null, null, null, null)
		}));
	}
}
