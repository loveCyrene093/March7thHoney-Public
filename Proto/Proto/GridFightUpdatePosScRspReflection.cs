using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUpdatePosScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUpdatePosScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1HcmlkRmlnaHRVcGRhdGVQb3NTY1JzcC5wcm90bxoWR3JpZEZpZ2h0UG9z";
		buffer[1] = "SW5mby5wcm90byJfChdHcmlkRmlnaHRVcGRhdGVQb3NTY1JzcBIPCgdyZXRj";
		buffer[2] = "b2RlGAQgASgNEjMKGGdyaWRfZmlnaHRfcG9zX2luZm9fbGlzdBgJIAMoCzIR";
		buffer[3] = "LkdyaWRGaWdodFBvc0luZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightPosInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUpdatePosScRsp), GridFightUpdatePosScRsp.Parser, new string[2] { "Retcode", "GridFightPosInfoList" }, null, null, null, null)
		}));
	}
}
