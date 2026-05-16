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
		buffer[0] = "CilEaWZmaWN1bHR5QWRqdXN0bWVudFVwZGF0ZURhdGFTY1JzcC5wcm90bxoR";
		buffer[1] = "TE1IT0lNTEdOR00ucHJvdG8ifgojRGlmZmljdWx0eUFkanVzdG1lbnRVcGRh";
		buffer[2] = "dGVEYXRhU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIaCgRkYXRhGAYgASgLMgwu";
		buffer[3] = "TE1IT0lNTEdOR00SKgoUY29udGVudF9wYWNrYWdlX2xpc3QYDCADKAsyDC5M";
		buffer[4] = "TUhPSU1MR05HTUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { LMHOIMLGNGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DifficultyAdjustmentUpdateDataScRsp), DifficultyAdjustmentUpdateDataScRsp.Parser, new string[3] { "Retcode", "Data", "ContentPackageList" }, null, null, null, null)
		}));
	}
}
