using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyDailySettleScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyDailySettleScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNb25vcG9seURhaWx5U2V0dGxlU2NOb3RpZnkucHJvdG8aEU9ET05MSERB" + "UEtCLnByb3RvIlUKG01vbm9wb2x5RGFpbHlTZXR0bGVTY05vdGlmeRIhCgtF" + "T0JFTkRQS0ZCTxgDIAEoCzIMLk9ET05MSERBUEtCEhMKC0xGR01NQVBLRElD" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ODONLHDAPKBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyDailySettleScNotify), MonopolyDailySettleScNotify.Parser, new string[2] { "EOBENDPKFBO", "LFGMMAPKDIC" }, null, null, null, null)
		}));
	}
}
