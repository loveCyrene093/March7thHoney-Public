using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceGetDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpDYWtlUmFjZUdldERhdGFTY1JzcC5wcm90byKMAQoUQ2FrZVJhY2VHZXRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXRhU2NSc3ASDwoHcmV0Y29kZRgDIAEoDRITCgtMQ0hEQVBFTFBHTxgFIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DRITCgtJSEdCQkhFQkxLTBgIIAMoDRIQCghzY29yZV9pZBgLIAEoDRITCgtQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "S09DRExIQlBJTRgNIAMoDRISCgppdGVtX3ZhbHVlGA4gASgNQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceGetDataScRsp), CakeRaceGetDataScRsp.Parser, new string[6] { "Retcode", "LCHDAPELPGO", "IHGBBHEBLKL", "ScoreId", "PKOCDLHBPIM", "ItemValue" }, null, null, null, null)
		}));
	}
}
