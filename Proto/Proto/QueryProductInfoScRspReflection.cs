using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QueryProductInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QueryProductInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtRdWVyeVByb2R1Y3RJbmZvU2NSc3AucHJvdG8aDVByb2R1Y3QucHJvdG8i";
		buffer[1] = "lAEKFVF1ZXJ5UHJvZHVjdEluZm9TY1JzcBIgChhtb250aF9jYXJkX291dF9k";
		buffer[2] = "YXRlX3RpbWUYBiABKAQSHgoMcHJvZHVjdF9saXN0GAggAygLMgguUHJvZHVj";
		buffer[3] = "dBITCgtJRktLS0xDRk9CSxgKIAEoDRIPCgdyZXRjb2RlGA0gASgNEhMKC0JB";
		buffer[4] = "TU9PR1BOSkVIGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[5] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ProductReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QueryProductInfoScRsp), QueryProductInfoScRsp.Parser, new string[5] { "MonthCardOutDateTime", "ProductList", "IFKKKLCFOBK", "Retcode", "BAMOOGPNJEH" }, null, null, null, null)
		}));
	}
}
