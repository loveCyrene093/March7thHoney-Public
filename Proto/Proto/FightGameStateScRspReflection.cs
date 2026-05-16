using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightGameStateScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightGameStateScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChlGaWdodEdhbWVTdGF0ZVNjUnNwLnByb3RvGhFBREhOSkFESUpBQy5wcm90";
		buffer[1] = "bxoRSUZDQkNCTEZBTE0ucHJvdG8aEUpMR05LTUJNUEtMLnByb3RvIo8BChNG";
		buffer[2] = "aWdodEdhbWVTdGF0ZVNjUnNwEiEKC1BPRk9DTUlISklBGAkgASgLMgwuSkxH";
		buffer[3] = "TktNQk1QS0wSIQoLQklFQkZIRUNFUE0YCyADKAsyDC5BREhOSkFESUpBQxIh";
		buffer[4] = "CgtPUE9HRU1BRExFSRgMIAEoCzIMLklGQ0JDQkxGQUxNEg8KB3JldGNvZGUY";
		buffer[5] = "DyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ADHNJADIJACReflection.Descriptor,
			IFCBCBLFALMReflection.Descriptor,
			JLGNKMBMPKLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightGameStateScRsp), FightGameStateScRsp.Parser, new string[4] { "POFOCMIHJIA", "BIEBFHECEPM", "OPOGEMADLEI", "Retcode" }, null, null, null, null)
		}));
	}
}
