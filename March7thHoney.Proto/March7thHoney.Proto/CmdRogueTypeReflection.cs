using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueTypeReflection()
	{
		_003C_003Ey__InlineArray37<string> buffer = default(_003C_003Ey__InlineArray37<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 0) = "ChJDbWRSb2d1ZVR5cGUucHJvdG8qxQwKDENtZFJvZ3VlVHlwZRIbChdPRUVM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 1) = "TkpMT0tIS19QQ1BESEVMUEtFTRAAEhcKEkNtZFN0YXJ0Um9ndWVTY1JzcBDn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 2) = "DhIZChRDbWRHZXRSb2d1ZUluZm9TY1JzcBCSDhIXChJDbWRMZWF2ZVJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 3) = "Q3NSZXEQkQ4SIwoeQ21kRXhjaGFuZ2VSb2d1ZVJld2FyZEtleVNjUnNwENUO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 4) = "Eh4KGUNtZEVudGVyUm9ndWVNYXBSb29tU2NSc3AQ5Q4SHQoYQ21kU3luY1Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 5) = "Z3VlQWVvblNjTm90aWZ5EMwOEhMKDkNtZExPUE9KREFBSVBPENwOEhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 6) = "ZFBOSEdJQU5HTkFFEJ4OEiAKG0NtZFN5bmNSb2d1ZUdldEl0ZW1TY05vdGlm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 7) = "eRDEDhIjCh5DbWRFeGNoYW5nZVJvZ3VlUmV3YXJkS2V5Q3NSZXEQlA4SIQoc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 8) = "Q21kVGFrZVJvZ3VlU2NvcmVSZXdhcmRTY1JzcBDCDhITCg5DbWRBQUJGTEdL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 9) = "Q0hDQRCpDhIXChJDbWRTdGFydFJvZ3VlQ3NSZXEQ5g4SJAofQ21kRmluaXNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 10) = "QWVvbkRpYWxvZ3VlR3JvdXBTY1JzcBCqDhIlCiBDbWRUYWtlUm9ndWVBZW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 11) = "TGV2ZWxSZXdhcmRDc1JlcRDrDhIdChhDbWRHZXRSb2d1ZUFlb25JbmZvU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 12) = "c3AQ1A4SHAoXT0VFTE5KTE9LSEtfR0lFSUZPTEVPRUcQig4SEwoOQ21kSkJP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 13) = "RUxMRkJGSEIQlw4SFwoSQ21kRW50ZXJSb2d1ZUNzUmVxEJYOEhMKDkNtZEdM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 14) = "S1BDUExCUExOEOgOEh0KGENtZEdldFJvZ3VlQWVvbkluZm9Dc1JlcRC4DhIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 15) = "Cg5DbWROTExKQkdQSkZJThDQDhIjCh5DbWRTeW5jUm9ndWVSZXZpdmVJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 16) = "U2NOb3RpZnkQ0Q4SFgoRQ21kUXVpdFJvZ3VlU2NSc3AQkA4SHgoZQ21kRW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 17) = "ZXJSb2d1ZU1hcFJvb21Dc1JlcRCcDhITCg5DbWRHSktPUEtMREZHQhCVDhIj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 18) = "Ch5DbWRTeW5jUm9ndWVFeHBsb3JlV2luU2NOb3RpZnkQuw4SHwoaQ21kU3lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 19) = "Y1JvZ3VlU3RhdHVzU2NOb3RpZnkQ2Q4SHgoZQ21kRW5hYmxlUm9ndWVUYWxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 20) = "bnRDc1JlcRDfDhIkCh9DbWRGaW5pc2hBZW9uRGlhbG9ndWVHcm91cENzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 21) = "ELYOEhYKEUNtZFF1aXRSb2d1ZUNzUmVxEL0OEhMKDkNtZEtFUE5HTUhDTkRO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 22) = "EOEOEhcKEkNtZExlYXZlUm9ndWVTY1JzcBDqDhIfChpDbWRHZXRSb2d1ZVRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 23) = "bGVudEluZm9Dc1JlcRDADhIcChdPRUVMTkpMT0tIS19PREVQT0lHQk1DQhCP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 24) = "DhITCg5DbWRCSURNSE9GRENJQxDsDhIlCiBDbWRTeW5jUm9ndWVTZWFzb25G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 25) = "aW5pc2hTY05vdGlmeRChDhIjCh5DbWRTeW5jUm9ndWVBcmVhVW5sb2NrU2NO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 26) = "b3RpZnkQ2g4SHwoaQ21kU3luY1JvZ3VlRmluaXNoU2NOb3RpZnkQjA4SHgoZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 27) = "Q21kRW5hYmxlUm9ndWVUYWxlbnRTY1JzcBCjDhIfChpDbWRHZXRSb2d1ZVRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 28) = "bGVudEluZm9TY1JzcBC1DhIhChxDbWRHZXRSb2d1ZUluaXRpYWxTY29yZVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 29) = "UnNwELkOEhMKDkNtZENJR0lJQ0VKTEpFEK4OEhsKFkNtZE9wZW5Sb2d1ZUNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 30) = "ZXN0U2NSc3AQpQ4SJAofQ21kR2V0Um9ndWVTY29yZVJld2FyZEluZm9TY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 31) = "cBDYDhITCg5DbWRESkZJQ01DQk5BRRDFDhIXChJDbWRFbnRlclJvZ3VlU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 32) = "c3AQmg4SHAoXT0VFTE5KTE9LSEtfR0xHUEVGTUFMUEUQ3g4SEwoOQ21kTU1J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 33) = "QkFDRk5FTEIQtA4SGwoWQ21kT3BlblJvZ3VlQ2hlc3RDc1JlcRDDDhIgChtD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 34) = "bWRTeW5jUm9ndWVNYXBSb29tU2NOb3RpZnkQyg4SGQoUQ21kR2V0Um9ndWVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 35) = "bmZvQ3NSZXEQ4w4SKAojQ21kU3luY1JvZ3VlVmlydHVhbEl0ZW1JbmZvU2NO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 36) = "b3RpZnkQtw5CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray37<string>, string>(in buffer, 37))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueType) }, null, null));
	}
}
