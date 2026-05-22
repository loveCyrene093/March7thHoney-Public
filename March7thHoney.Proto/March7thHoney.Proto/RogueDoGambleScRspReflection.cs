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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhSb2d1ZURvR2FtYmxlU2NSc3AucHJvdG8aEURLRkFFS1BLQURILnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "InIKElJvZ3VlRG9HYW1ibGVTY1JzcBIhCgtDRkFERkxMTE9QQxgFIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "LkRLRkFFS1BLQURIEg8KB3JldGNvZGUYBiABKA0SEwoLT0hBSENCT0xESUEY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DSABKA0SEwoLTEtIUE1QRUdKRUUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { DKFAEKPKADHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueDoGambleScRsp), RogueDoGambleScRsp.Parser, new string[4] { "CFADFLLLOPC", "Retcode", "OHAHCBOLDIA", "LKHPMPEGJEE" }, null, null, null, null)
		}));
	}
}
