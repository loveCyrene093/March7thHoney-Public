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
		buffer[0] = "ChdDbWRCYXR0bGVQYXNzVHlwZS5wcm90byruAQoRQ21kQmF0dGxlUGFzc1R5";
		buffer[1] = "cGUSGwoXRkdIQUdMTE9QR0hfUENQREhFTFBLRU0QABIcChdDbWRCYXR0bGVQ";
		buffer[2] = "YXNzSW5mb05vdGlmeRCTGBIZChRDbWRUYWtlQnBSZXdhcmRDc1JlcRCXGBIZ";
		buffer[3] = "ChRDbWRUYWtlQnBSZXdhcmRTY1JzcBDGFxIaChVDbWRUYWtlQWxsUmV3YXJk";
		buffer[4] = "U2NSc3AQ9xcSGgoVQ21kVGFrZUFsbFJld2FyZENzUmVxEJoYEhcKEkNtZEJ1";
		buffer[5] = "eUJwTGV2ZWxTY1JzcBDBFxIXChJDbWRCdXlCcExldmVsQ3NSZXEQyhdCFqoC";
		buffer[6] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdBattlePassType) }, null, null));
	}
}
