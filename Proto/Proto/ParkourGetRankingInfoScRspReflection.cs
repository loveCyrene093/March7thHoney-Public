using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ParkourGetRankingInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ParkourGetRankingInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBQYXJrb3VyR2V0UmFua2luZ0luZm9TY1JzcC5wcm90bxoRQUZEQkVGS0JC";
		buffer[1] = "Rk0ucHJvdG8icwoaUGFya291ckdldFJhbmtpbmdJbmZvU2NSc3ASIQoLREVI";
		buffer[2] = "QkFQRk1CTUIYAiADKAsyDC5BRkRCRUZLQkJGTRIhCgtJTURDRUZFR0lQQhgE";
		buffer[3] = "IAEoCzIMLkFGREJFRktCQkZNEg8KB3JldGNvZGUYBiABKA1CFqoCE01hcmNo";
		buffer[4] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AFDBEFKBBFMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ParkourGetRankingInfoScRsp), ParkourGetRankingInfoScRsp.Parser, new string[3] { "DEHBAPFMBMB", "IMDCEFEGIPB", "Retcode" }, null, null, null, null)
		}));
	}
}
