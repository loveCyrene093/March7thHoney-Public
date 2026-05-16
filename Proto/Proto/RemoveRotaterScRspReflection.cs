using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RemoveRotaterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RemoveRotaterScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChhSZW1vdmVSb3RhdGVyU2NSc3AucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv";
		buffer[1] = "GhdSb3RhdGVyRW5lcmd5SW5mby5wcm90byJyChJSZW1vdmVSb3RhdGVyU2NS";
		buffer[2] = "c3ASJwoLZW5lcmd5X2luZm8YASABKAsyEi5Sb3RhdGVyRW5lcmd5SW5mbxIi";
		buffer[3] = "Cgxyb3RhdGVyX2RhdGEYCSABKAsyDC5Sb3RhdGVyRGF0YRIPCgdyZXRjb2Rl";
		buffer[4] = "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			RotaterDataReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RemoveRotaterScRsp), RemoveRotaterScRsp.Parser, new string[3] { "EnergyInfo", "RotaterData", "Retcode" }, null, null, null, null)
		}));
	}
}
