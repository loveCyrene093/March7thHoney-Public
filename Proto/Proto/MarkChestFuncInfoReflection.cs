using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkChestFuncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkChestFuncInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdNYXJrQ2hlc3RGdW5jSW5mby5wcm90bxoTTWFya0NoZXN0SW5mby5wcm90";
		buffer[1] = "byJlChFNYXJrQ2hlc3RGdW5jSW5mbxIsChRtYXJrX2NoZXN0X2luZm9fbGlz";
		buffer[2] = "dBgDIAMoCzIOLk1hcmtDaGVzdEluZm8SDwoHZnVuY19pZBgHIAEoDRIRCglt";
		buffer[3] = "YXJrX3RpbWUYCCABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MarkChestInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkChestFuncInfo), MarkChestFuncInfo.Parser, new string[3] { "MarkChestInfoList", "FuncId", "MarkTime" }, null, null, null, null)
		}));
	}
}
