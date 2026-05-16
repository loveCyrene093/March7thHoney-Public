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
		buffer[0] = "ChpDYWtlUmFjZUdldERhdGFTY1JzcC5wcm90byKMAQoUQ2FrZVJhY2VHZXRE";
		buffer[1] = "YXRhU2NSc3ASDwoHcmV0Y29kZRgDIAEoDRITCgtMQ0hEQVBFTFBHTxgFIAEo";
		buffer[2] = "DRITCgtJSEdCQkhFQkxLTBgIIAMoDRIQCghzY29yZV9pZBgLIAEoDRITCgtQ";
		buffer[3] = "S09DRExIQlBJTRgNIAMoDRISCgppdGVtX3ZhbHVlGA4gASgNQhaqAhNNYXJj";
		buffer[4] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceGetDataScRsp), CakeRaceGetDataScRsp.Parser, new string[6] { "Retcode", "LCHDAPELPGO", "IHGBBHEBLKL", "ScoreId", "PKOCDLHBPIM", "ItemValue" }, null, null, null, null)
		}));
	}
}
