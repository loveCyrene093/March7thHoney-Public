using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdShopTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdShopTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFDbWRTaG9wVHlwZS5wcm90byrgAQoLQ21kU2hvcFR5cGUSGwoXRk1PSkNG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "TVBDTkFfUENQREhFTFBLRU0QABITCg5DbWRFRkxHTE9LTkJLUBDuCxIcChdD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "bWRDaXR5U2hvcEluZm9TY05vdGlmeRDlCxIVChBDbWRCdXlHb29kc0NzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "ELoMEh8KGkNtZFRha2VDaXR5U2hvcFJld2FyZENzUmVxEOoLEhUKEENtZEJ1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "eUdvb2RzU2NSc3AQuwwSGAoTQ21kR2V0U2hvcExpc3RTY1JzcBDmCxIYChND";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "bWRHZXRTaG9wTGlzdENzUmVxELcMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdShopType) }, null, null));
	}
}
