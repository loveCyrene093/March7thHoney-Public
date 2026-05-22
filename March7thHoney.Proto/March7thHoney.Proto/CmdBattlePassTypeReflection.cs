using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdBattlePassTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdBattlePassTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChdDbWRCYXR0bGVQYXNzVHlwZS5wcm90byruAQoRQ21kQmF0dGxlUGFzc1R5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "cGUSGwoXRkdIQUdMTE9QR0hfUENQREhFTFBLRU0QABIcChdDbWRCYXR0bGVQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "YXNzSW5mb05vdGlmeRCTGBIZChRDbWRUYWtlQnBSZXdhcmRDc1JlcRCXGBIZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "ChRDbWRUYWtlQnBSZXdhcmRTY1JzcBDGFxIaChVDbWRUYWtlQWxsUmV3YXJk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "U2NSc3AQ9xcSGgoVQ21kVGFrZUFsbFJld2FyZENzUmVxEJoYEhcKEkNtZEJ1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "eUJwTGV2ZWxTY1JzcBDBFxIXChJDbWRCdXlCcExldmVsQ3NSZXEQyhdCFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdBattlePassType) }, null, null));
	}
}
