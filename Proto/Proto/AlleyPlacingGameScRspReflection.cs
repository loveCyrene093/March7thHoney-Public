using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AlleyPlacingGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AlleyPlacingGameScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtBbGxleVBsYWNpbmdHYW1lU2NSc3AucHJvdG8iuAEKFUFsbGV5UGxhY2lu";
		buffer[1] = "Z0dhbWVTY1JzcBITCgtHS09BSEJLRURITBgBIAEoDRIPCgdyZXRjb2RlGAMg";
		buffer[2] = "ASgNEhMKC0hHSUZFS0VGQ0FOGAUgASgNEhMKC0FITlBNR0xPSUVIGAYgASgN";
		buffer[3] = "EhMKC0tIRUJDT1BFR0tDGAogASgNEhMKC01BQkZEQkNEQ0ROGAsgASgNEhAK";
		buffer[4] = "CGV2ZW50X2lkGA0gASgNEhMKC0xETE9KSkdOSk1KGA4gASgNQhaqAhNNYXJj";
		buffer[5] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AlleyPlacingGameScRsp), AlleyPlacingGameScRsp.Parser, new string[8] { "GKOAHBKEDHL", "Retcode", "HGIFEKEFCAN", "AHNPMGLOIEH", "KHEBCOPEGKC", "MABFDBCDCDN", "EventId", "LDLOJJGNJMJ" }, null, null, null, null)
		}));
	}
}
