using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveChallengeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveChallengeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlMZWF2ZUNoYWxsZW5nZVNjUnNwLnByb3RvIiYKE0xlYXZlQ2hhbGxlbmdl" + "U2NSc3ASDwoHcmV0Y29kZRgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveChallengeScRsp), LeaveChallengeScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
