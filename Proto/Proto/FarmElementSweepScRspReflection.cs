using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FarmElementSweepScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FarmElementSweepScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtGYXJtRWxlbWVudFN3ZWVwU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv";
		buffer[1] = "ImYKFUZhcm1FbGVtZW50U3dlZXBTY1JzcBIVCg1GYXJtRWxlbWVudElkGAYg";
		buffer[2] = "ASgNEg8KB3JldGNvZGUYDCABKA0SJQoSbXVsdGlwbGVfZHJvcF9kYXRhGA4g";
		buffer[3] = "ASgLMgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FarmElementSweepScRsp), FarmElementSweepScRsp.Parser, new string[3] { "FarmElementId", "Retcode", "MultipleDropData" }, null, null, null, null)
		}));
	}
}
