using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournLeaveRogueCocoonSceneScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournLeaveRogueCocoonSceneScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CipSb2d1ZVRvdXJuTGVhdmVSb2d1ZUNvY29vblNjZW5lU2NSc3AucHJvdG8a";
		buffer[1] = "EUJGRUlQRUxGQ0RGLnByb3RvIloKJFJvZ3VlVG91cm5MZWF2ZVJvZ3VlQ29j";
		buffer[2] = "b29uU2NlbmVTY1JzcBIhCgtBRkxKSkpGQ0JJThgMIAEoCzIMLkJGRUlQRUxG";
		buffer[3] = "Q0RGEg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BFEIPELFCDFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLeaveRogueCocoonSceneScRsp), RogueTournLeaveRogueCocoonSceneScRsp.Parser, new string[2] { "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}
