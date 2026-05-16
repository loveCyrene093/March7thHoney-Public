using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnterRogueCocoonSceneScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnterRogueCocoonSceneScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CipSb2d1ZVRvdXJuRW50ZXJSb2d1ZUNvY29vblNjZW5lU2NSc3AucHJvdG8a";
		buffer[1] = "EUJGRUlQRUxGQ0RGLnByb3RvIloKJFJvZ3VlVG91cm5FbnRlclJvZ3VlQ29j";
		buffer[2] = "b29uU2NlbmVTY1JzcBIhCgtBRkxKSkpGQ0JJThgNIAEoCzIMLkJGRUlQRUxG";
		buffer[3] = "Q0RGEg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BFEIPELFCDFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterRogueCocoonSceneScRsp), RogueTournEnterRogueCocoonSceneScRsp.Parser, new string[2] { "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}
