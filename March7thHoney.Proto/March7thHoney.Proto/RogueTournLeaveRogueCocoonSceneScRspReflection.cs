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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CipSb2d1ZVRvdXJuTGVhdmVSb2d1ZUNvY29vblNjZW5lU2NSc3AucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "EUJGRUlQRUxGQ0RGLnByb3RvIloKJFJvZ3VlVG91cm5MZWF2ZVJvZ3VlQ29j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "b29uU2NlbmVTY1JzcBIhCgtBRkxKSkpGQ0JJThgMIAEoCzIMLkJGRUlQRUxG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Q0RGEg8KB3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { BFEIPELFCDFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLeaveRogueCocoonSceneScRsp), RogueTournLeaveRogueCocoonSceneScRsp.Parser, new string[2] { "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}
