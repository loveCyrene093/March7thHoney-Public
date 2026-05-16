using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DifficultyAdjustmentGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DifficultyAdjustmentGetDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZEaWZmaWN1bHR5QWRqdXN0bWVudEdldERhdGFTY1JzcC5wcm90bxoRTE1I";
		buffer[1] = "T0lNTEdOR00ucHJvdG8iXwogRGlmZmljdWx0eUFkanVzdG1lbnRHZXREYXRh";
		buffer[2] = "U2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIqChRjb250ZW50X3BhY2thZ2VfbGlz";
		buffer[3] = "dBgDIAMoCzIMLkxNSE9JTUxHTkdNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[4] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { LMHOIMLGNGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DifficultyAdjustmentGetDataScRsp), DifficultyAdjustmentGetDataScRsp.Parser, new string[2] { "Retcode", "ContentPackageList" }, null, null, null, null)
		}));
	}
}
