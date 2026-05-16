using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FeverTimeBattleRankReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FeverTimeBattleRankReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChlGZXZlclRpbWVCYXR0bGVSYW5rLnByb3RvKqYBChNGZXZlclRpbWVCYXR0";
		buffer[1] = "bGVSYW5rEhsKF0dLTkxHSUJDTENOX0lKTEpGUEtJRU9QEAASGwoXR0tOTEdJ";
		buffer[2] = "QkNMQ05fQUJNQk9NSlBNTkQQARIbChdHS05MR0lCQ0xDTl9FRkxKRERCQ0lG";
		buffer[3] = "RBACEhsKF0dLTkxHSUJDTENOX0NLT0RMREVQRVBHEAMSGwoXR0tOTEdJQkNM";
		buffer[4] = "Q05fRENQTkFJTElLRk0QBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[5] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FeverTimeBattleRank) }, null, null));
	}
}
