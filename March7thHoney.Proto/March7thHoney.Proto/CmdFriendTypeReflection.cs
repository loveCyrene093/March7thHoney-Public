using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFriendTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFriendTypeReflection()
	{
		_003C_003Ey__InlineArray45<string> buffer = default(_003C_003Ey__InlineArray45<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 0) = "ChNDbWRGcmllbmRUeXBlLnByb3RvKogPCg1DbWRGcmllbmRUeXBlEhsKF0dF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 1) = "R0hJRUhORUVQX1BDUERIRUxQS0VNEAASIwoeQ21kR2V0RnJpZW5kQXBwbHlM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 2) = "aXN0SW5mb1NjUnNwEOYWEiAKG0NtZFN5bmNIYW5kbGVGcmllbmRTY05vdGlm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 3) = "eRDVFhIiCh1DbWRHZXRQbGF0Zm9ybVBsYXllckluZm9TY1JzcBCFFxInCiJD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 4) = "bWRHZXRGcmllbmRSZWNvbW1lbmRMaXN0SW5mb1NjUnNwEJEXEisKJkNtZEdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 5) = "dEZyaWVuZFJlY29tbWVuZExpbmV1cERldGFpbENzUmVxEIgXEhoKFUNtZEdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 6) = "dEFzc2lzdExpc3RDc1JlcRDwFhIdChhDbWRUYWtlQXNzaXN0UmV3YXJkU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 7) = "c3AQ6BYSEwoOQ21kQUJOTEtJRERJT0sQuBcSGQoUQ21kRGVsZXRlRnJpZW5k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 8) = "Q3NSZXEQnhcSGgoVQ21kR2V0QXNzaXN0TGlzdFNjUnNwEJUXEhkKFENtZFJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 9) = "cG9ydFBsYXllckNzUmVxEIAXEiAKG0NtZEdldFBsYXllckRldGFpbEluZm9D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 10) = "c1JlcRCyFxIlCiBDbWRHZXRGcmllbmREZXZlbG9wbWVudEluZm9Dc1JlcRCh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 11) = "FxIjCh5DbWRHZXRGcmllbmRBcHBseUxpc3RJbmZvQ3NSZXEQ4hYSJQogQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 12) = "R2V0RnJpZW5kUmVjb21tZW5kTGluZXVwU2NSc3AQrBcSGQoUQ21kR2V0Q3Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 13) = "QXNzaXN0U2NSc3AQ5RYSGgoVQ21kU2V0RnJpZW5kTWFya0NzUmVxEJsXEiIK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 14) = "HUNtZEdldFBsYXRmb3JtUGxheWVySW5mb0NzUmVxENYWEhkKFENtZEFkZEJs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 15) = "YWNrbGlzdENzUmVxEPoWEiUKIENtZEdldEZyaWVuZFJlY29tbWVuZExpbmV1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 16) = "cENzUmVxENoWEh8KGkNtZEdldEZyaWVuZExvZ2luSW5mb0NzUmVxEJYXEiAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 17) = "G0NtZFNldEZyaWVuZFJlbWFya05hbWVDc1JlcRDbFhIeChlDbWRDdXJBc3Np";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 18) = "c3RDaGFuZ2VkTm90aWZ5ELEXEh4KGUNtZEdldEZyaWVuZExpc3RJbmZvQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 19) = "ZXEQrxcSHQoYQ21kR2V0QXNzaXN0SGlzdG9yeVNjUnNwEO0WEiAKG0NtZFN5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 20) = "bmNEZWxldGVGcmllbmRTY05vdGlmeRDYFhIoCiNDbWRHZXRGcmllbmRCYXR0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 21) = "bGVSZWNvcmREZXRhaWxTY1JzcBDgFhIgChtDbWRTeW5jQWRkQmxhY2tsaXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 22) = "U2NOb3RpZnkQ9BYSGgoVQ21kU2V0RnJpZW5kTWFya1NjUnNwEPgWEh0KGENt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 23) = "ZFRha2VBc3Npc3RSZXdhcmRDc1JlcRCjFxIZChRDbWREZWxldGVGcmllbmRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 24) = "Y1JzcBD5FhIYChNDbWRBcHBseUZyaWVuZFNjUnNwELYXEhkKFENtZFNlYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 25) = "aFBsYXllckNzUmVxEI0XEhYKEUNtZFNldEFzc2lzdENzUmVxEJ0XEh8KGkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 26) = "ZFN5bmNBcHBseUZyaWVuZFNjTm90aWZ5EJMXEiAKG0NtZEdldEZyaWVuZEFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 27) = "c2lzdExpc3RDc1JlcRDXFhIZChRDbWRIYW5kbGVGcmllbmRTY1JzcBD7FhIc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 28) = "ChdDbWREZWxldGVCbGFja2xpc3RTY1JzcBC0FxIoCiNDbWRHZXRGcmllbmRC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 29) = "YXR0bGVSZWNvcmREZXRhaWxDc1JlcRDxFhIgChtDbWRHZXRGcmllbmRBc3Np";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 30) = "c3RMaXN0U2NSc3AQsBcSHAoXQ21kRGVsZXRlQmxhY2tsaXN0Q3NSZXEQrRcS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 31) = "GAoTQ21kQXBwbHlGcmllbmRDc1JlcRDdFhIrCiZDbWRHZXRGcmllbmRSZWNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 32) = "bW1lbmRMaW5ldXBEZXRhaWxTY1JzcBCuFxIlCiBDbWRTZXRBbGxvd090aGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 33) = "QXBwbHlGcmllbmRDc1JlcRDfFhIZChRDbWRIYW5kbGVGcmllbmRDc1JlcRDu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 34) = "FhIZChRDbWRHZXRDdXJBc3Npc3RDc1JlcRDcFhIeChlDbWRHZXRGcmllbmRM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 35) = "aXN0SW5mb1NjUnNwEN4WEiAKG0NtZFNldEZyaWVuZFJlbWFya05hbWVTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 36) = "cBCOFxIdChhDbWRHZXRBc3Npc3RIaXN0b3J5Q3NSZXEQhxcSJgohQ21kU2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 37) = "Rm9yYmlkT3RoZXJBcHBseUZyaWVuZFNjUnNwEPIWEiAKG0NtZEdldFBsYXll";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 38) = "ckRldGFpbEluZm9TY1JzcBCzFxIlCiBDbWRHZXRGcmllbmREZXZlbG9wbWVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 39) = "dEluZm9TY1JzcBDkFhIZChRDbWRBZGRCbGFja2xpc3RTY1JzcBCcFxInCiJD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 40) = "bWRHZXRGcmllbmRSZWNvbW1lbmRMaXN0SW5mb0NzUmVxEPUWEh8KGkNtZEdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 41) = "dEZyaWVuZExvZ2luSW5mb1NjUnNwENkWEhYKEUNtZFNldEFzc2lzdFNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 42) = "EIkXEhkKFENtZFNlYXJjaFBsYXllclNjUnNwEOkWEh4KGUNtZE5ld0Fzc2lz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 43) = "dEhpc3RvcnlOb3RpZnkQihdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray45<string>, string>(ref buffer, 44) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray45<string>, string>(in buffer, 45))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFriendType) }, null, null));
	}
}
