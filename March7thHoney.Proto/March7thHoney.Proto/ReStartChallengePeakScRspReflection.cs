using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReStartChallengePeakScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReStartChallengePeakScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZVN0YXJ0Q2hhbGxlbmdlUGVha1NjUnNwLnByb3RvIiwKGVJlU3RhcnRD" + "aGFsbGVuZ2VQZWFrU2NSc3ASDwoHcmV0Y29kZRgLIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReStartChallengePeakScRsp), ReStartChallengePeakScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
