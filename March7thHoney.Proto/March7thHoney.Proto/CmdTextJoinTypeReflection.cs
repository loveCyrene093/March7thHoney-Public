using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdTextJoinTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdTextJoinTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChVDbWRUZXh0Sm9pblR5cGUucHJvdG8q2QEKD0NtZFRleHRKb2luVHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "ChdDS0NFRUJPS0xKSl9QQ1BESEVMUEtFTRAAEhMKDkNtZElOQ0pOSkdFSENE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "EOIdEh4KGUNtZFRleHRKb2luQmF0Y2hTYXZlU2NSc3AQ6h0SHgoZQ21kVGV4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "dEpvaW5CYXRjaFNhdmVDc1JlcRDmHRIaChVDbWRUZXh0Sm9pblF1ZXJ5U2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "c3AQtx4SGgoVQ21kVGV4dEpvaW5RdWVyeUNzUmVxELYeEhwKF0NLQ0VFQk9L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "TEpKX0xORUFGRklBSkpMELMeQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdTextJoinType) }, null, null));
	}
}
