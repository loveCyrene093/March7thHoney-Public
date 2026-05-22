using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdAlleyTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdAlleyTypeReflection()
	{
		_003C_003Ey__InlineArray27<string> buffer = default(_003C_003Ey__InlineArray27<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 0) = "ChJDbWRBbGxleVR5cGUucHJvdG8q6wgKDENtZEFsbGV5VHlwZRIbChdNT0ZM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 1) = "T0pOSkRHTF9QQ1BESEVMUEtFTRAAEhMKDkNtZEtDT0JNT1BLTFBMEL4lEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 2) = "DkNtZE1DUEhBUE5MTklHEJElEhoKFUNtZFNhdmVMb2dpc3RpY3NDc1JlcRC8";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 3) = "JRIkCh9DbWRBY3Rpdml0eVJhaWRQbGFjaW5nR2FtZUNzUmVxELklEiAKG0Nt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 4) = "ZEdldFNhdmVMb2dpc3RpY3NNYXBDc1JlcRCdJRIZChRDbWRHZXRBbGxleUlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 5) = "Zm9Dc1JlcRC3JRITCg5DbWRGQkRKRUpESENJTxC1JRIZChRDbWRHZXRBbGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 6) = "eUluZm9TY1JzcBDmJBIpCiRDbWRBbGxleVNoaXBtZW50RXZlbnRFZmZlY3Rz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 7) = "U2NOb3RpZnkQ+CQSLAonQ21kTG9naXN0aWNzU2NvcmVSZXdhcmRTeW5jSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 8) = "b1NjTm90aWZ5EPAkEhMKDkNtZEhDRElIT0JQTEpFEPYkEhwKF01PRkxPSk5K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 9) = "REdMX0hNQ01MSEVBQktJEPwkEhoKFUNtZEFsbGV5RnVuZHNTY05vdGlmeRCI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 10) = "JRITCg5DbWRMT0lOR0JOR0RGTxDtJBIcChdNT0ZMT0pOSkRHTF9PTEpJSEVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 11) = "RUJDQRDkJBIeChlDbWRBbGxleUV2ZW50Q2hhbmdlTm90aWZ5EJslEhoKFUNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 12) = "ZExvZ2lzdGljc0dhbWVTY1JzcBC7JRIdChhDbWRBbGxleVBsYWNpbmdHYW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 13) = "U2NSc3AQgSUSHAoXTU9GTE9KTkpER0xfQ05HQUdMS0JIUEsQpCUSIQocQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 14) = "QWxsZXlPcmRlckNoYW5nZWRTY05vdGlmeRD9JBITCg5DbWRJSk1JQ09NQ0ZL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 15) = "SxCrJRIcChdDbWRQcmVzdGlnZUxldmVsVXBTY1JzcBCWJRIcChdDbWRUYWtl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 16) = "RXZlbnRSZXdhcmRDc1JlcRCPJRIhChxDbWRBbGxleVRha2VFdmVudFJld2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 17) = "ZFNjUnNwEPUkEhwKF0NtZFByZXN0aWdlTGV2ZWxVcENzUmVxEOMkEhoKFUNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 18) = "ZExvZ2lzdGljc0dhbWVDc1JlcRC6JRInCiJDbWRMb2dpc3RpY3NEZXRvbmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 19) = "ZVN0YXJTa2lmZkNzUmVxEJIlEhwKF0NtZFN0YXJ0QWxsZXlFdmVudENzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 20) = "EOUkEiQKH0NtZEFjdGl2aXR5UmFpZFBsYWNpbmdHYW1lU2NSc3AQ3iQSHAoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 21) = "TU9GTE9KTkpER0xfS0tKUEdPTU9QQUkQwCUSHQoYQ21kTG9naXN0aWNzSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 22) = "b1NjTm90aWZ5EPEkEhMKDkNtZEtDSEVQTEtNT05MEJUlEiAKG0NtZEdldFNh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 23) = "dmVMb2dpc3RpY3NNYXBTY1JzcBClJRIfChpDbWRUYWtlUHJlc3RpZ2VSZXdh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 24) = "cmRDc1JlcRCDJRIdChhDbWRBbGxleVBsYWNpbmdHYW1lQ3NSZXEQpiUSHwoa";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 25) = "Q21kVGFrZVByZXN0aWdlUmV3YXJkU2NSc3AQ3SRCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray27<string>, string>(ref buffer, 26) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray27<string>, string>(in buffer, 27))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdAlleyType) }, null, null));
	}
}
