using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetChallengePeakBossHardModeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetChallengePeakBossHardModeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidTZXRDaGFsbGVuZ2VQZWFrQm9zc0hhcmRNb2RlU2NSc3AucHJvdG8iYQoh" + "U2V0Q2hhbGxlbmdlUGVha0Jvc3NIYXJkTW9kZVNjUnNwEhQKDGlzX2hhcmRf" + "bW9kZRgBIAEoCBIPCgdyZXRjb2RlGAUgASgNEhUKDXBlYWtfZ3JvdXBfaWQY" + "DyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetChallengePeakBossHardModeScRsp), SetChallengePeakBossHardModeScRsp.Parser, new string[3] { "IsHardMode", "Retcode", "PeakGroupId" }, null, null, null, null)
		}));
	}
}
