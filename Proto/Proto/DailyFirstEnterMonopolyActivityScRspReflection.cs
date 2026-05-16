using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DailyFirstEnterMonopolyActivityScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DailyFirstEnterMonopolyActivityScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CipEYWlseUZpcnN0RW50ZXJNb25vcG9seUFjdGl2aXR5U2NSc3AucHJvdG8a";
		buffer[1] = "EU9ET05MSERBUEtCLnByb3RvIpkBCiREYWlseUZpcnN0RW50ZXJNb25vcG9s";
		buffer[2] = "eUFjdGl2aXR5U2NSc3ASIQoLRU9CRU5EUEtGQk8YAyABKAsyDC5PRE9OTEhE";
		buffer[3] = "QVBLQhITCgtMRkdNTUFQS0RJQxgEIAEoDRIPCgdyZXRjb2RlGAkgASgNEhMK";
		buffer[4] = "C0xORVBIR01FSkhKGA0gASgIEhMKC0NJTFBJSk5PSUFHGA4gASgDQhaqAhNN";
		buffer[5] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ODONLHDAPKBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DailyFirstEnterMonopolyActivityScRsp), DailyFirstEnterMonopolyActivityScRsp.Parser, new string[5] { "EOBENDPKFBO", "LFGMMAPKDIC", "Retcode", "LNEPHGMEJHJ", "CILPIJNOIAG" }, null, null, null, null)
		}));
	}
}
