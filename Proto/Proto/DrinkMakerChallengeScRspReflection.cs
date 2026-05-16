using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DrinkMakerChallengeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DrinkMakerChallengeScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5Ecmlua01ha2VyQ2hhbGxlbmdlU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnBy";
		buffer[1] = "b3RvInEKGERyaW5rTWFrZXJDaGFsbGVuZ2VTY1JzcBIPCgdyZXRjb2RlGAMg";
		buffer[2] = "ASgNEhkKBnJld2FyZBgIIAEoCzIJLkl0ZW1MaXN0EhMKC0RBSUtOS0FMS0NN";
		buffer[3] = "GAwgASgIEhQKDGNoYWxsZW5nZV9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DrinkMakerChallengeScRsp), DrinkMakerChallengeScRsp.Parser, new string[4] { "Retcode", "Reward", "DAIKNKALKCM", "ChallengeId" }, null, null, null, null)
		}));
	}
}
