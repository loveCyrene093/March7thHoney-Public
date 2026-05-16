using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMonopolyTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMonopolyTypeReflection()
	{
		_003C_003Ey__InlineArray69<string> buffer = default(_003C_003Ey__InlineArray69<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 0) = "ChVDbWRNb25vcG9seVR5cGUucHJvdG8quxcKD0NtZE1vbm9wb2x5VHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 1) = "ChdCT05PSEpMQkpISF9QQ1BESEVMUEtFTRAAEiYKIUNtZE1vbm9wb2x5R2Ft";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 2) = "ZUJpbmdvRmxpcENhcmRDc1JlcRCLNxITCg5DbWRISk9ITE1IRkhJRRChNxIl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 3) = "CiBDbWRNb25vcG9seUNvbnRlbnRVcGRhdGVTY05vdGlmeRD0NhIfChpDbWRN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 4) = "b25vcG9seVJvbGxSYW5kb21Dc1JlcRDcNhIZChRDbWRNb25vcG9seUxpa2VT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 5) = "Y1JzcBCTNxInCiJDbWRNb25vcG9seUV2ZW50TG9hZFVwZGF0ZVNjTm90aWZ5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 6) = "EK03EiYKIUNtZEdldFNvY2lhbEV2ZW50U2VydmVyQ2FjaGVTY1JzcBCyNxIf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 7) = "ChpDbWRNb25vcG9seVJvbGxSYW5kb21TY1JzcBD+NhIdChhDbWRNb25vcG9s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 8) = "eUJ1eUdvb2RzU2NSc3AQkjcSHgoZQ21kTW9ub3BvbHlDbGlja0NlbGxTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 9) = "cBCkNxImCiFDbWRNb25vcG9seUdldFJhZmZsZVBvb2xJbmZvQ3NSZXEQ+zYS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 10) = "JAofQ21kTW9ub3BvbHlHZXRSYWZmbGVUaWNrZXRDc1JlcRCeNxImCiFDbWRN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 11) = "b25vcG9seUV2ZW50U2VsZWN0RnJpZW5kQ3NSZXEQ6DYSJgohQ21kTW9ub3Bv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 12) = "bHlHZXRSZWdpb25Qcm9ncmVzc1NjUnNwEKs3Eh0KGENtZE1vbm9wb2x5QnV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 13) = "R29vZHNDc1JlcRDfNhIjCh5DbWRHZXRNb25vcG9seURhaWx5UmVwb3J0U2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 14) = "c3AQozcSIQocQ21kTW9ub3BvbHlHdWVzc0RyYXdTY05vdGlmeRDdNhIlCiBD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 15) = "bWRNb25vcG9seUdpdmVVcEN1ckNvbnRlbnRTY1JzcBC4NxIjCh5DbWRNb25v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 16) = "cG9seUdhbWVSYWlzZVJhdGlvQ3NSZXEQmTcSHgoZQ21kTW9ub3BvbHlDaGVh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 17) = "dERpY2VTY1JzcBDtNhIeChlDbWRNb25vcG9seUNoZWF0RGljZUNzUmVxEJE3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 18) = "EioKJUNtZE1vbm9wb2x5UXVpekR1cmF0aW9uQ2hhbmdlU2NOb3RpZnkQ4zYS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 19) = "HAoXQ21kTW9ub3BvbHlMaWtlU2NOb3RpZnkQ9TYSJwoiQ21kTW9ub3BvbHlD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 20) = "b25kaXRpb25VcGRhdGVTY05vdGlmeRCQNxIiCh1DbWRNb25vcG9seUNvbmZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 21) = "cm1SYW5kb21Dc1JlcRD5NhIgChtDbWRNb25vcG9seUd1ZXNzQ2hvb3NlQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 22) = "ZXEQtTcSIAobQ21kTW9ub3BvbHlDZWxsVXBkYXRlTm90aWZ5ELc3EiEKHENt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 23) = "ZE1vbm9wb2x5UmVSb2xsUmFuZG9tQ3NSZXEQoDcSJgohQ21kR2V0U29jaWFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 24) = "RXZlbnRTZXJ2ZXJDYWNoZUNzUmVxEIw3EicKIkNtZE1vbm9wb2x5U2NyYWNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 25) = "UmFmZmxlVGlja2V0Q3NSZXEQuzcSJgohQ21kTW9ub3BvbHlHYW1lQmluZ29G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 26) = "bGlwQ2FyZFNjUnNwEPE2EiMKHkNtZE1vbm9wb2x5RGFpbHlTZXR0bGVTY05v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 27) = "dGlmeRC0NxIpCiRDbWRHZXRNb25vcG9seUZyaWVuZFJhbmtpbmdMaXN0U2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 28) = "c3AQpjcSLAonQ21kRGFpbHlGaXJzdEVudGVyTW9ub3BvbHlBY3Rpdml0eVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 29) = "UnNwEP02EhwKF0NtZEdldE1vbm9wb2x5SW5mb1NjUnNwEOI2EiIKHUNtZE1v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 30) = "bm9wb2x5R2FtZUNyZWF0ZVNjTm90aWZ5EOw2EisKJkNtZE1vbm9wb2x5VGFr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 31) = "ZVJhZmZsZVRpY2tldFJld2FyZENzUmVxEKo3EiUKIENtZE1vbm9wb2x5R2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 32) = "RGFpbHlJbml0SXRlbVNjUnNwEPo2EigKI0NtZE1vbm9wb2x5R3Vlc3NCdXlJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 33) = "bmZvcm1hdGlvbkNzUmVxEIk3EiwKJ0NtZERhaWx5Rmlyc3RFbnRlck1vbm9w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 34) = "b2x5QWN0aXZpdHlDc1JlcRCiNxIpCiRDbWRHZXRNb25vcG9seUZyaWVuZFJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 35) = "bmtpbmdMaXN0Q3NSZXEQ8DYSKwomQ21kTW9ub3BvbHlUYWtlUmFmZmxlVGlj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 36) = "a2V0UmV3YXJkU2NSc3AQlDcSGQoUQ21kTW9ub3BvbHlNb3ZlU2NSc3AQlzcS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 37) = "HQoYQ21kTW9ub3BvbHlSb2xsRGljZUNzUmVxEOo2Eh8KGkNtZE1vbm9wb2x5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 38) = "QWNjZXB0UXVpelNjUnNwEKc3EiEKHENtZE1vbm9wb2x5U2VsZWN0T3B0aW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 39) = "U2NSc3AQ/zYSJAofQ21kTW9ub3BvbHlHZXRSYWZmbGVUaWNrZXRTY1JzcBCc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 40) = "NxIhChxDbWRNb25vcG9seVNlbGVjdE9wdGlvbkNzUmVxEPI2Eh0KGENtZE1v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 41) = "bm9wb2x5Um9sbERpY2VTY1JzcBDhNhIaChVDbWRHZXRNYnRpUmVwb3J0U2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 42) = "c3AQpTcSEwoOQ21kRkZCS01GRkhGUEIQgTcSEwoOQ21kT0tNS0JCSU9KR04Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 43) = "rzcSJAofQ21kTW9ub3BvbHlBY3Rpb25SZXN1bHRTY05vdGlmeRC2NxIiCh1D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 44) = "bWRNb25vcG9seUdhbWVTZXR0bGVTY05vdGlmeRCNNxIeChlDbWRNb25vcG9s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 45) = "eUdhbWVHYWNoYVNjUnNwEOk2EiUKIENtZE1vbm9wb2x5R2V0RGFpbHlJbml0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 46) = "SXRlbUNzUmVxEIY3EigKI0NtZEdldE1vbm9wb2x5TWJ0aVJlcG9ydFJld2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 47) = "ZENzUmVxEIA3EiUKIENtZE1vbm9wb2x5R2l2ZVVwQ3VyQ29udGVudENzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 48) = "ELE3EhkKFENtZE1vbm9wb2x5TW92ZUNzUmVxELo3EiYKIUNtZE1vbm9wb2x5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 49) = "RXZlbnRTZWxlY3RGcmllbmRTY1JzcBDeNhInCiJDbWRNb25vcG9seVNjcmFj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 50) = "aFJhZmZsZVRpY2tldFNjUnNwEOU2Eh4KGUNtZE1vbm9wb2x5Q2xpY2tDZWxs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 51) = "Q3NSZXEQiDcSHgoZQ21kTW9ub3BvbHlHYW1lR2FjaGFDc1JlcRDgNhIhChxD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 52) = "bWRNb25vcG9seVJlUm9sbFJhbmRvbVNjUnNwEPg2EhkKFENtZE1vbm9wb2x5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 53) = "TGlrZUNzUmVxEII3Eh8KGkNtZE1vbm9wb2x5QWNjZXB0UXVpekNzUmVxEI43";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 54) = "EiQKH0NtZE1vbm9wb2x5VGFrZVBoYXNlUmV3YXJkQ3NSZXEQrjcSJgohQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 55) = "TW9ub3BvbHlHZXRSZWdpb25Qcm9ncmVzc0NzUmVxEPc2EikKJENtZERlbGV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 56) = "ZVNvY2lhbEV2ZW50U2VydmVyQ2FjaGVDc1JlcRCdNxIcChdDbWRHZXRNb25v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 57) = "cG9seUluZm9Dc1JlcRCzNxIjCh5DbWRHZXRNb25vcG9seURhaWx5UmVwb3J0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 58) = "Q3NSZXEQuTcSKAojQ21kR2V0TW9ub3BvbHlNYnRpUmVwb3J0UmV3YXJkU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 59) = "c3AQgzcSJAofQ21kTW9ub3BvbHlUYWtlUGhhc2VSZXdhcmRTY1JzcBCoNxIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 60) = "Cg5DbWROQUZDRUNFRkRNTBCaNxIiCh1DbWRNb25vcG9seUNvbmZpcm1SYW5k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 61) = "b21TY1JzcBCVNxIgChtDbWRNb25vcG9seUd1ZXNzQ2hvb3NlU2NSc3AQ2jYS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 62) = "EwoOQ21kSU1KTUdIQ0hGQUEQvDcSKQokQ21kTW9ub3BvbHlTb2NpYWxFdmVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 63) = "dEVmZmVjdFNjTm90aWZ5ELA3EiEKHENtZE1vbm9wb2x5U3R0VXBkYXRlU2NO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 64) = "b3RpZnkQjzcSGgoVQ21kR2V0TWJ0aVJlcG9ydENzUmVxEOQ2EiQKH0NtZE1v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 65) = "bm9wb2x5Q2xpY2tNYnRpUmVwb3J0Q3NSZXEQhTcSJgohQ21kTW9ub3BvbHlH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 66) = "ZXRSYWZmbGVQb29sSW5mb1NjUnNwEOc2EiEKHENtZE1vbm9wb2x5VXBncmFk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 67) = "ZUFzc2V0Q3NSZXEQhDdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray69<string>, string>(ref buffer, 68) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray69<string>, string>(in buffer, 69))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMonopolyType) }, null, null));
	}
}
