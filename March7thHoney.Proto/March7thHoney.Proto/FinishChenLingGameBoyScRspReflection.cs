using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishChenLingGameBoyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishChenLingGameBoyScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiBGaW5pc2hDaGVuTGluZ0dhbWVCb3lTY1JzcC5wcm90bxoOSXRlbUxpc3Qu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "cHJvdG8inAEKGkZpbmlzaENoZW5MaW5nR2FtZUJveVNjUnNwEhMKC0lDTUtH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "RkxCRUpQGAIgAygNEhMKC0dQSkhKT09JSkpDGAQgASgNEhMKC0dJQU9JTU9G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QUxIGAYgASgEEhMKC0hIS0NBREtDTEpDGAsgASgEEhkKBnJld2FyZBgMIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "CzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYDSABKA1CFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishChenLingGameBoyScRsp), FinishChenLingGameBoyScRsp.Parser, new string[6] { "ICMKGFLBEJP", "GPJHJOOIJJC", "GIAOIMOFALH", "HHKCADKCLJC", "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
