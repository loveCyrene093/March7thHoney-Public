using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeBenefitActivityRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeBenefitActivityRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRUYWtlQmVuZWZpdEFjdGl2aXR5UmV3YXJkU2NSc3AucHJvdG8aEURPTU9F";
		buffer[1] = "T09ITEpBLnByb3RvGg5JdGVtTGlzdC5wcm90byJ0Ch5UYWtlQmVuZWZpdEFj";
		buffer[2] = "dGl2aXR5UmV3YXJkU2NSc3ASIQoLc3dpdGNoX2xpc3QYAiADKAsyDC5ET01P";
		buffer[3] = "RU9PSExKQRIeCgtEQk1GSklJT0ZPSRgNIAEoCzIJLkl0ZW1MaXN0Eg8KB3Jl";
		buffer[4] = "dGNvZGUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DOMOEOOHLJAReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeBenefitActivityRewardScRsp), TakeBenefitActivityRewardScRsp.Parser, new string[3] { "SwitchList", "DBMFJIIOFOI", "Retcode" }, null, null, null, null)
		}));
	}
}
