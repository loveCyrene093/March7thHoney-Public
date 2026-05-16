using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVDaGFsbGVuZ2VTdGF0dXMucHJvdG8qaQoPQ2hhbGxlbmdlU3RhdHVzEhUK" + "EUNIQUxMRU5HRV9VTktOT1dOEAASEwoPQ0hBTExFTkdFX0RPSU5HEAESFAoQ" + "Q0hBTExFTkdFX0ZJTklTSBACEhQKEENIQUxMRU5HRV9GQUlMRUQQA0IWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChallengeStatus) }, null, null));
	}
}
