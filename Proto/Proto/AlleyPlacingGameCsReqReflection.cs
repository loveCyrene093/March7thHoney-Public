using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AlleyPlacingGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AlleyPlacingGameCsReqReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChtBbGxleVBsYWNpbmdHYW1lQ3NSZXEucHJvdG8aFkFsbGV5UGxhY2luZ1No";
		buffer[1] = "aXAucHJvdG8i5QEKFUFsbGV5UGxhY2luZ0dhbWVDc1JlcRITCgtNQU1HR0ZL";
		buffer[2] = "R0tDRRgDIAEoDRIRCgljb3N0X3RpbWUYBSABKA0SJgoLRkNEQ0ZBTU9IQUUY";
		buffer[3] = "CCABKAsyES5BbGxleVBsYWNpbmdTaGlwEhMKC09ORVBOUEdQTU5PGAkgASgN";
		buffer[4] = "EhMKC1BCREpPSUlBS0hLGAogASgNEhMKC0tFQk9ETk9NTkRKGAsgASgNEhMK";
		buffer[5] = "C0ZPQkdCR0NPS0FFGA0gASgNEhMKC0JISlBFQUFCT0dQGA4gASgNEhMKC09C";
		buffer[6] = "UE5ES1BQRkdHGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[7] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AlleyPlacingShipReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AlleyPlacingGameCsReq), AlleyPlacingGameCsReq.Parser, new string[9] { "MAMGGFKGKCE", "CostTime", "FCDCFAMOHAE", "ONEPNPGPMNO", "PBDJOIIAKHK", "KEBODNOMNDJ", "FOBGBGCOKAE", "BHJPEAABOGP", "OBPNDKPPFGG" }, null, null, null, null)
		}));
	}
}
