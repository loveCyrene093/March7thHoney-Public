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
		buffer[0] = "ChJDbWRBbGxleVR5cGUucHJvdG8q6wgKDENtZEFsbGV5VHlwZRIbChdNT0ZM";
		buffer[1] = "T0pOSkRHTF9QQ1BESEVMUEtFTRAAEhMKDkNtZEtDT0JNT1BLTFBMEL4lEhMK";
		buffer[2] = "DkNtZE1DUEhBUE5MTklHEJElEhoKFUNtZFNhdmVMb2dpc3RpY3NDc1JlcRC8";
		buffer[3] = "JRIkCh9DbWRBY3Rpdml0eVJhaWRQbGFjaW5nR2FtZUNzUmVxELklEiAKG0Nt";
		buffer[4] = "ZEdldFNhdmVMb2dpc3RpY3NNYXBDc1JlcRCdJRIZChRDbWRHZXRBbGxleUlu";
		buffer[5] = "Zm9Dc1JlcRC3JRITCg5DbWRGQkRKRUpESENJTxC1JRIZChRDbWRHZXRBbGxl";
		buffer[6] = "eUluZm9TY1JzcBDmJBIpCiRDbWRBbGxleVNoaXBtZW50RXZlbnRFZmZlY3Rz";
		buffer[7] = "U2NOb3RpZnkQ+CQSLAonQ21kTG9naXN0aWNzU2NvcmVSZXdhcmRTeW5jSW5m";
		buffer[8] = "b1NjTm90aWZ5EPAkEhMKDkNtZEhDRElIT0JQTEpFEPYkEhwKF01PRkxPSk5K";
		buffer[9] = "REdMX0hNQ01MSEVBQktJEPwkEhoKFUNtZEFsbGV5RnVuZHNTY05vdGlmeRCI";
		buffer[10] = "JRITCg5DbWRMT0lOR0JOR0RGTxDtJBIcChdNT0ZMT0pOSkRHTF9PTEpJSEVC";
		buffer[11] = "RUJDQRDkJBIeChlDbWRBbGxleUV2ZW50Q2hhbmdlTm90aWZ5EJslEhoKFUNt";
		buffer[12] = "ZExvZ2lzdGljc0dhbWVTY1JzcBC7JRIdChhDbWRBbGxleVBsYWNpbmdHYW1l";
		buffer[13] = "U2NSc3AQgSUSHAoXTU9GTE9KTkpER0xfQ05HQUdMS0JIUEsQpCUSIQocQ21k";
		buffer[14] = "QWxsZXlPcmRlckNoYW5nZWRTY05vdGlmeRD9JBITCg5DbWRJSk1JQ09NQ0ZL";
		buffer[15] = "SxCrJRIcChdDbWRQcmVzdGlnZUxldmVsVXBTY1JzcBCWJRIcChdDbWRUYWtl";
		buffer[16] = "RXZlbnRSZXdhcmRDc1JlcRCPJRIhChxDbWRBbGxleVRha2VFdmVudFJld2Fy";
		buffer[17] = "ZFNjUnNwEPUkEhwKF0NtZFByZXN0aWdlTGV2ZWxVcENzUmVxEOMkEhoKFUNt";
		buffer[18] = "ZExvZ2lzdGljc0dhbWVDc1JlcRC6JRInCiJDbWRMb2dpc3RpY3NEZXRvbmF0";
		buffer[19] = "ZVN0YXJTa2lmZkNzUmVxEJIlEhwKF0NtZFN0YXJ0QWxsZXlFdmVudENzUmVx";
		buffer[20] = "EOUkEiQKH0NtZEFjdGl2aXR5UmFpZFBsYWNpbmdHYW1lU2NSc3AQ3iQSHAoX";
		buffer[21] = "TU9GTE9KTkpER0xfS0tKUEdPTU9QQUkQwCUSHQoYQ21kTG9naXN0aWNzSW5m";
		buffer[22] = "b1NjTm90aWZ5EPEkEhMKDkNtZEtDSEVQTEtNT05MEJUlEiAKG0NtZEdldFNh";
		buffer[23] = "dmVMb2dpc3RpY3NNYXBTY1JzcBClJRIfChpDbWRUYWtlUHJlc3RpZ2VSZXdh";
		buffer[24] = "cmRDc1JlcRCDJRIdChhDbWRBbGxleVBsYWNpbmdHYW1lQ3NSZXEQpiUSHwoa";
		buffer[25] = "Q21kVGFrZVByZXN0aWdlUmV3YXJkU2NSc3AQ3SRCFqoCE01hcmNoN3RoSG9u";
		buffer[26] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdAlleyType) }, null, null));
	}
}
