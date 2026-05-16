using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueTournTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueTournTypeReflection()
	{
		_003C_003Ey__InlineArray68<string> buffer = default(_003C_003Ey__InlineArray68<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 0) = "ChdDbWRSb2d1ZVRvdXJuVHlwZS5wcm90byqyFwoRQ21kUm9ndWVUb3VyblR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 1) = "cGUSGwoXSUFNQ0ZETE5LT0xfUENQREhFTFBLRU0QABIjCh5DbWRSb2d1ZVRv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 2) = "dXJuU2F2ZUJ1aWxkUmVmU2NSc3AQ0y8SLQooQ21kUm9ndWVUb3VybkdldFBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 3) = "cm1hbmVudFRhbGVudEluZm9Dc1JlcRDKLxIkCh9DbWRSb2d1ZVRvdXJuVGFr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 4) = "ZUV4cFJld2FyZFNjUnNwENEvEhwKF0NtZFJvZ3VlVG91cm5RdWVyeVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 5) = "EK0vEjMKLkNtZFJvZ3VlVG91cm5QZXJzb25hUm9vbUNhcmRab25lVXBkYXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 6) = "U2NOb3RpZnkQqi8SHAoXQ21kUm9ndWVUb3VybkxlYXZlQ3NSZXEQli8SJAof";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 7) = "Q21kUm9ndWVUb3VybkNvbmZpcm1TZXR0bGVDc1JlcRCkLxIhChxDbWRSb2d1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 8) = "ZVRvdXJuRW50ZXJMYXllckNzUmVxEIIvEiAKG0NtZFJvZ3VlVG91cm5FbnRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 9) = "clJvb21TY1JzcBDJLxITCg5DbWRDS0VQSE9KREFBRBCiLxIsCidDbWRSb2d1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 10) = "ZVRvdXJuRW5hYmxlUGVybWFuZW50VGFsZW50Q3NSZXEQmi8SKwomQ21kUm9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 11) = "dWVUb3VybkdldEFyY2hpdmVSZXBvc2l0b3J5Q3NSZXEQii8SHAoXQ21kUm9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 12) = "dWVUb3VybkxlYXZlU2NSc3AQgS8SJQogQ21kUm91Z2VUb3VyblJlbmFtZUJ1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 13) = "aWxkUmVmQ3NSZXEQvy8SLgopQ21kUm9ndWVUb3VyblJlRW50ZXJSb2d1ZUNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 14) = "Y29vblN0YWdlQ3NSZXEQti8SKgolQ21kUm9ndWVUb3VybkdldFNlYXNvblRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 15) = "bGVudEluZm9Dc1JlcRC8LxIuCilDbWRSb2d1ZVRvdXJuQmF0dGxlRmFpbFNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 16) = "dHRsZUluZm9TY05vdGlmeRCPLxIsCidDbWRSb2d1ZVRvdXJuTGVhdmVSb2d1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 17) = "ZUNvY29vblNjZW5lQ3NSZXEQ/C4SJAofQ21kUm9ndWVUb3VybkdldEFsbEFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 18) = "Y2hpdmVDc1JlcRC+LxIkCh9DbWRSb2d1ZVRvdXJuQ29uZmlybVNldHRsZVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 19) = "UnNwELMvEiwKJ0NtZFJvZ3VlVG91cm5FbnRlclJvZ3VlQ29jb29uU2NlbmVD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 20) = "c1JlcRCOLxIkCh9DbWRSb2d1ZVRvdXJuRGVsZXRlQXJjaGl2ZUNzUmVxEKMv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 21) = "EiMKHkNtZFJvZ3VlVG91cm5TYXZlQnVpbGRSZWZDc1JlcRC3LxIcChdDbWRS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 22) = "b2d1ZVRvdXJuU3RhcnRTY1JzcBCILxIkCh9DbWRSb2d1ZVRvdXJuRGVsZXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 23) = "QXJjaGl2ZVNjUnNwEMAvEigKI0NtZFJvZ3VlVG91cm5Vc2VTdXBlclJld2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 24) = "ZEtleUNzUmVxEIkvEiQKH0NtZFJvZ3VlVG91cm5HZXRTZXR0bGVJbmZvQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 25) = "ZXEQzC8SHAoXQ21kUm9ndWVUb3VybkVudGVyQ3NSZXEQ0i8SHAoXQ21kUm9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 26) = "dWVUb3VyblF1ZXJ5Q3NSZXEQky8SKQokQ21kUm9ndWVUb3VybkVuYWJsZVNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 27) = "YXNvblRhbGVudENzUmVxELAvEisKJkNtZFJvZ3VlVG91cm5HZXRBcmNoaXZl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 28) = "UmVwb3NpdG9yeVNjUnNwEIAvEh0KGENtZFJvZ3VlVG91cm5TZXR0bGVTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 29) = "cBDQLxIgChtDbWRSb2d1ZVRvdXJuSGFuZEJvb2tOb3RpZnkQuC8SGwoWQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 30) = "Um9ndWVUb3VybkV4cE5vdGlmeRC7LxIkCh9DbWRSb2d1ZVRvdXJuVGFrZUV4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 31) = "cFJld2FyZENzUmVxEJQvEisKJkNtZFJvZ3VlVG91cm5SZXNldFBlcm1hbmVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 32) = "dFRhbGVudENzUmVxEIsvEioKJUNtZFJvZ3VlVG91cm5DbGVhckFyY2hpdmVO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 33) = "YW1lU2NOb3RpZnkQri8SLQooQ21kUm9ndWVUb3VybldlZWtDaGFsbGVuZ2VV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 34) = "cGRhdGVTY05vdGlmeRCXLxIsCidDbWRSb2d1ZVRvdXJuRW50ZXJSb2d1ZUNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 35) = "Y29vblNjZW5lU2NSc3AQny8SIQocQ21kUm9ndWVUb3VybkVudGVyTGF5ZXJT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 36) = "Y1JzcBCMLxIjCh5DbWRSb2d1ZVRvdXJuUmV2aXZlQXZhdGFyU2NSc3AQgy8S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 37) = "JQogQ21kUm9ndWVUb3VybkdldEFsbEJ1aWxkUmVmU2NSc3AQmC8SHAoXQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 38) = "Um9ndWVUb3VybkVudGVyU2NSc3AQzy8SJQogQ21kUm9ndWVUb3VybkRlbGV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 39) = "ZUJ1aWxkUmVmU2NSc3AQmS8SJQogQ21kUm9ndWVUb3VybkdldEFsbEJ1aWxk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 40) = "UmVmQ3NSZXEQ1C8SKgolQ21kUm9ndWVUb3VyblJldml2ZUNvc3RVcGRhdGVT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 41) = "Y05vdGlmeRDILxITCg5DbWRQTENMSExOQUhEQhCxLxIlCiBDbWRSb2d1ZVRv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 42) = "dXJuUmVuYW1lQnVpbGRSZWZTY1JzcBCdLxIgChtDbWRSb2d1ZVRvdXJuRW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 43) = "ZXJSb29tQ3NSZXEQhC8SJAofQ21kUm9ndWVUb3VyblJlbmFtZUFyY2hpdmVD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 44) = "c1JlcRCbLxIqCiVDbWRSb2d1ZVRvdXJuR2V0TWlzY1JlYWxUaW1lRGF0YVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 45) = "UnNwEMEvEiQKH0NtZFJvZ3VlVG91cm5SZW5hbWVBcmNoaXZlU2NSc3AQxS8S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 46) = "EwoOQ21kSExHS0hESUxDSEgQpS8SKAojQ21kUm9ndWVUb3VyblRyaWdnZXJS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 47) = "b29tU2VsZWN0Q3NSZXEQwy8SEwoOQ21kTEdGQUpESUtDSk4Qxi8SIwoeQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 48) = "Um9ndWVUb3VyblJldml2ZUF2YXRhckNzUmVxEKYvEioKJUNtZFJvZ3VlVG91";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 49) = "cm5HZXRNaXNjUmVhbFRpbWVEYXRhQ3NSZXEQhi8SJAofQ21kUm9ndWVUb3Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 50) = "bkdldFNldHRsZUluZm9TY1JzcBCSLxIoCiNDbWRSb2d1ZVRvdXJuVXNlU3Vw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 51) = "ZXJSZXdhcmRLZXlTY1JzcBDHLxI3CjJDbWRSb2d1ZVRvdXJuVGl0YW5VcGRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 52) = "dGVUaXRhbkJsZXNzUHJvZ3Jlc3NTY05vdGlmeRC5LxIsCidDbWRSb2d1ZVRv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 53) = "dXJuR2V0Q3VyUm9ndWVDb2Nvb25JbmZvQ3NSZXEQni8SJAofQ21kUm9ndWVU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 54) = "b3VybkdldEFsbEFyY2hpdmVTY1JzcBD+LhITCg5DbWRMR0FDRU9GSkpCSxC1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 55) = "LxItCihDbWRSb2d1ZVRvdXJuR2V0UGVybWFuZW50VGFsZW50SW5mb1NjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 56) = "EKEvEh0KGENtZFJvZ3VlVG91cm5TZXR0bGVDc1JlcRD7LhIqCiVDbWRSb2d1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 57) = "ZVRvdXJuR2V0U2Vhc29uVGFsZW50SW5mb1NjUnNwEK8vEikKJENtZFJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 58) = "VG91cm5FbmFibGVTZWFzb25UYWxlbnRTY1JzcBCFLxIpCiRDbWRSb2d1ZVRv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 59) = "dXJuTGV2ZWxJbmZvVXBkYXRlU2NOb3RpZnkQqy8SLAonQ21kUm9ndWVUb3Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 60) = "bkxlYXZlUm9ndWVDb2Nvb25TY2VuZVNjUnNwEMQvEi4KKUNtZFJvZ3VlVG91";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 61) = "cm5SZUVudGVyUm9ndWVDb2Nvb25TdGFnZVNjUnNwEP8uEiUKIENtZFJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 62) = "VG91cm5EZWxldGVCdWlsZFJlZkNzUmVxEIcvEisKJkNtZFJvZ3VlVG91cm5S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 63) = "ZXNldFBlcm1hbmVudFRhbGVudFNjUnNwEM0vEiQKH0NtZFJvZ3VlVG91cm5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 64) = "cmVhVXBkYXRlU2NOb3RpZnkQoC8SHAoXQ21kUm9ndWVUb3VyblN0YXJ0Q3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 65) = "ZXEQtC8SLAonQ21kUm9ndWVUb3VybkVuYWJsZVBlcm1hbmVudFRhbGVudFNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 66) = "UnNwEMIvEiwKJ0NtZFJvZ3VlVG91cm5HZXRDdXJSb2d1ZUNvY29vbkluZm9T";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 67) = "Y1JzcBD9LkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray68<string>, string>(in buffer, 68))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueTournType) }, null, null));
	}
}
