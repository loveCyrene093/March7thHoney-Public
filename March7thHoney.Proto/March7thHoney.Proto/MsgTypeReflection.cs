using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MsgTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MsgTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "Cg1Nc2dUeXBlLnByb3RvKvoBCgdNc2dUeXBlEhEKDU1TR19UWVBFX05PTkUQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "ABIYChRNU0dfVFlQRV9DVVNUT01fVEVYVBABEhIKDk1TR19UWVBFX0VNT0pJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "EAISEwoPTVNHX1RZUEVfSU5WSVRFEAMSFwoTTVNHX1RZUEVfUExBTkVUX0ZF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "UxAEEhgKFE1TR19UWVBFX0FDSUVMTU9MRUxCEAUSGAoUTVNHX1RZUEVfQkdE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "TUxHRE1ESUYQBhIYChRNU0dfVFlQRV9NR0xQTE9QRUNHShAHEhgKFE1TR19U";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "WVBFX1BQR0JGTU9HQUhDEAgSGAoUTVNHX1RZUEVfQkFFS0hPSExMS0oQCUIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MsgType) }, null, null));
	}
}
