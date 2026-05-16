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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZEaWZmaWN1bHR5QWRqdXN0bWVudEdldERhdGFTY1JzcC5wcm90bxoRTE1I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "T0lNTEdOR00ucHJvdG8iXwogRGlmZmljdWx0eUFkanVzdG1lbnRHZXREYXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "U2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIqChRjb250ZW50X3BhY2thZ2VfbGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "dBgDIAMoCzIMLkxNSE9JTUxHTkdNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { LMHOIMLGNGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DifficultyAdjustmentGetDataScRsp), DifficultyAdjustmentGetDataScRsp.Parser, new string[2] { "Retcode", "ContentPackageList" }, null, null, null, null)
		}));
	}
}
