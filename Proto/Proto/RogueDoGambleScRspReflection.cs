using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueDoGambleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueDoGambleScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChhSb2d1ZURvR2FtYmxlU2NSc3AucHJvdG8aEURLRkFFS1BLQURILnByb3Rv";
		buffer[1] = "InIKElJvZ3VlRG9HYW1ibGVTY1JzcBIhCgtDRkFERkxMTE9QQxgFIAEoCzIM";
		buffer[2] = "LkRLRkFFS1BLQURIEg8KB3JldGNvZGUYBiABKA0SEwoLT0hBSENCT0xESUEY";
		buffer[3] = "DSABKA0SEwoLTEtIUE1QRUdKRUUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DKFAEKPKADHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueDoGambleScRsp), RogueDoGambleScRsp.Parser, new string[4] { "CFADFLLLOPC", "Retcode", "OHAHCBOLDIA", "LKHPMPEGJEE" }, null, null, null, null)
		}));
	}
}
