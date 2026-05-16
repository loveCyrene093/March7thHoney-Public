using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DifficultyAdjustmentUpdateDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DifficultyAdjustmentUpdateDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CilEaWZmaWN1bHR5QWRqdXN0bWVudFVwZGF0ZURhdGFTY1JzcC5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TE1IT0lNTEdOR00ucHJvdG8ifgojRGlmZmljdWx0eUFkanVzdG1lbnRVcGRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dGVEYXRhU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIaCgRkYXRhGAYgASgLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TE1IT0lNTEdOR00SKgoUY29udGVudF9wYWNrYWdlX2xpc3QYDCADKAsyDC5M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TUhPSU1MR05HTUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { LMHOIMLGNGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DifficultyAdjustmentUpdateDataScRsp), DifficultyAdjustmentUpdateDataScRsp.Parser, new string[3] { "Retcode", "Data", "ContentPackageList" }, null, null, null, null)
		}));
	}
}
