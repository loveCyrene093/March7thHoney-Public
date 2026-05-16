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
		buffer[0] = "ChdDbWRSb2d1ZVRvdXJuVHlwZS5wcm90byqyFwoRQ21kUm9ndWVUb3VyblR5";
		buffer[1] = "cGUSGwoXSUFNQ0ZETE5LT0xfUENQREhFTFBLRU0QABIjCh5DbWRSb2d1ZVRv";
		buffer[2] = "dXJuU2F2ZUJ1aWxkUmVmU2NSc3AQ0y8SLQooQ21kUm9ndWVUb3VybkdldFBl";
		buffer[3] = "cm1hbmVudFRhbGVudEluZm9Dc1JlcRDKLxIkCh9DbWRSb2d1ZVRvdXJuVGFr";
		buffer[4] = "ZUV4cFJld2FyZFNjUnNwENEvEhwKF0NtZFJvZ3VlVG91cm5RdWVyeVNjUnNw";
		buffer[5] = "EK0vEjMKLkNtZFJvZ3VlVG91cm5QZXJzb25hUm9vbUNhcmRab25lVXBkYXRl";
		buffer[6] = "U2NOb3RpZnkQqi8SHAoXQ21kUm9ndWVUb3VybkxlYXZlQ3NSZXEQli8SJAof";
		buffer[7] = "Q21kUm9ndWVUb3VybkNvbmZpcm1TZXR0bGVDc1JlcRCkLxIhChxDbWRSb2d1";
		buffer[8] = "ZVRvdXJuRW50ZXJMYXllckNzUmVxEIIvEiAKG0NtZFJvZ3VlVG91cm5FbnRl";
		buffer[9] = "clJvb21TY1JzcBDJLxITCg5DbWRDS0VQSE9KREFBRBCiLxIsCidDbWRSb2d1";
		buffer[10] = "ZVRvdXJuRW5hYmxlUGVybWFuZW50VGFsZW50Q3NSZXEQmi8SKwomQ21kUm9n";
		buffer[11] = "dWVUb3VybkdldEFyY2hpdmVSZXBvc2l0b3J5Q3NSZXEQii8SHAoXQ21kUm9n";
		buffer[12] = "dWVUb3VybkxlYXZlU2NSc3AQgS8SJQogQ21kUm91Z2VUb3VyblJlbmFtZUJ1";
		buffer[13] = "aWxkUmVmQ3NSZXEQvy8SLgopQ21kUm9ndWVUb3VyblJlRW50ZXJSb2d1ZUNv";
		buffer[14] = "Y29vblN0YWdlQ3NSZXEQti8SKgolQ21kUm9ndWVUb3VybkdldFNlYXNvblRh";
		buffer[15] = "bGVudEluZm9Dc1JlcRC8LxIuCilDbWRSb2d1ZVRvdXJuQmF0dGxlRmFpbFNl";
		buffer[16] = "dHRsZUluZm9TY05vdGlmeRCPLxIsCidDbWRSb2d1ZVRvdXJuTGVhdmVSb2d1";
		buffer[17] = "ZUNvY29vblNjZW5lQ3NSZXEQ/C4SJAofQ21kUm9ndWVUb3VybkdldEFsbEFy";
		buffer[18] = "Y2hpdmVDc1JlcRC+LxIkCh9DbWRSb2d1ZVRvdXJuQ29uZmlybVNldHRsZVNj";
		buffer[19] = "UnNwELMvEiwKJ0NtZFJvZ3VlVG91cm5FbnRlclJvZ3VlQ29jb29uU2NlbmVD";
		buffer[20] = "c1JlcRCOLxIkCh9DbWRSb2d1ZVRvdXJuRGVsZXRlQXJjaGl2ZUNzUmVxEKMv";
		buffer[21] = "EiMKHkNtZFJvZ3VlVG91cm5TYXZlQnVpbGRSZWZDc1JlcRC3LxIcChdDbWRS";
		buffer[22] = "b2d1ZVRvdXJuU3RhcnRTY1JzcBCILxIkCh9DbWRSb2d1ZVRvdXJuRGVsZXRl";
		buffer[23] = "QXJjaGl2ZVNjUnNwEMAvEigKI0NtZFJvZ3VlVG91cm5Vc2VTdXBlclJld2Fy";
		buffer[24] = "ZEtleUNzUmVxEIkvEiQKH0NtZFJvZ3VlVG91cm5HZXRTZXR0bGVJbmZvQ3NS";
		buffer[25] = "ZXEQzC8SHAoXQ21kUm9ndWVUb3VybkVudGVyQ3NSZXEQ0i8SHAoXQ21kUm9n";
		buffer[26] = "dWVUb3VyblF1ZXJ5Q3NSZXEQky8SKQokQ21kUm9ndWVUb3VybkVuYWJsZVNl";
		buffer[27] = "YXNvblRhbGVudENzUmVxELAvEisKJkNtZFJvZ3VlVG91cm5HZXRBcmNoaXZl";
		buffer[28] = "UmVwb3NpdG9yeVNjUnNwEIAvEh0KGENtZFJvZ3VlVG91cm5TZXR0bGVTY1Jz";
		buffer[29] = "cBDQLxIgChtDbWRSb2d1ZVRvdXJuSGFuZEJvb2tOb3RpZnkQuC8SGwoWQ21k";
		buffer[30] = "Um9ndWVUb3VybkV4cE5vdGlmeRC7LxIkCh9DbWRSb2d1ZVRvdXJuVGFrZUV4";
		buffer[31] = "cFJld2FyZENzUmVxEJQvEisKJkNtZFJvZ3VlVG91cm5SZXNldFBlcm1hbmVu";
		buffer[32] = "dFRhbGVudENzUmVxEIsvEioKJUNtZFJvZ3VlVG91cm5DbGVhckFyY2hpdmVO";
		buffer[33] = "YW1lU2NOb3RpZnkQri8SLQooQ21kUm9ndWVUb3VybldlZWtDaGFsbGVuZ2VV";
		buffer[34] = "cGRhdGVTY05vdGlmeRCXLxIsCidDbWRSb2d1ZVRvdXJuRW50ZXJSb2d1ZUNv";
		buffer[35] = "Y29vblNjZW5lU2NSc3AQny8SIQocQ21kUm9ndWVUb3VybkVudGVyTGF5ZXJT";
		buffer[36] = "Y1JzcBCMLxIjCh5DbWRSb2d1ZVRvdXJuUmV2aXZlQXZhdGFyU2NSc3AQgy8S";
		buffer[37] = "JQogQ21kUm9ndWVUb3VybkdldEFsbEJ1aWxkUmVmU2NSc3AQmC8SHAoXQ21k";
		buffer[38] = "Um9ndWVUb3VybkVudGVyU2NSc3AQzy8SJQogQ21kUm9ndWVUb3VybkRlbGV0";
		buffer[39] = "ZUJ1aWxkUmVmU2NSc3AQmS8SJQogQ21kUm9ndWVUb3VybkdldEFsbEJ1aWxk";
		buffer[40] = "UmVmQ3NSZXEQ1C8SKgolQ21kUm9ndWVUb3VyblJldml2ZUNvc3RVcGRhdGVT";
		buffer[41] = "Y05vdGlmeRDILxITCg5DbWRQTENMSExOQUhEQhCxLxIlCiBDbWRSb2d1ZVRv";
		buffer[42] = "dXJuUmVuYW1lQnVpbGRSZWZTY1JzcBCdLxIgChtDbWRSb2d1ZVRvdXJuRW50";
		buffer[43] = "ZXJSb29tQ3NSZXEQhC8SJAofQ21kUm9ndWVUb3VyblJlbmFtZUFyY2hpdmVD";
		buffer[44] = "c1JlcRCbLxIqCiVDbWRSb2d1ZVRvdXJuR2V0TWlzY1JlYWxUaW1lRGF0YVNj";
		buffer[45] = "UnNwEMEvEiQKH0NtZFJvZ3VlVG91cm5SZW5hbWVBcmNoaXZlU2NSc3AQxS8S";
		buffer[46] = "EwoOQ21kSExHS0hESUxDSEgQpS8SKAojQ21kUm9ndWVUb3VyblRyaWdnZXJS";
		buffer[47] = "b29tU2VsZWN0Q3NSZXEQwy8SEwoOQ21kTEdGQUpESUtDSk4Qxi8SIwoeQ21k";
		buffer[48] = "Um9ndWVUb3VyblJldml2ZUF2YXRhckNzUmVxEKYvEioKJUNtZFJvZ3VlVG91";
		buffer[49] = "cm5HZXRNaXNjUmVhbFRpbWVEYXRhQ3NSZXEQhi8SJAofQ21kUm9ndWVUb3Vy";
		buffer[50] = "bkdldFNldHRsZUluZm9TY1JzcBCSLxIoCiNDbWRSb2d1ZVRvdXJuVXNlU3Vw";
		buffer[51] = "ZXJSZXdhcmRLZXlTY1JzcBDHLxI3CjJDbWRSb2d1ZVRvdXJuVGl0YW5VcGRh";
		buffer[52] = "dGVUaXRhbkJsZXNzUHJvZ3Jlc3NTY05vdGlmeRC5LxIsCidDbWRSb2d1ZVRv";
		buffer[53] = "dXJuR2V0Q3VyUm9ndWVDb2Nvb25JbmZvQ3NSZXEQni8SJAofQ21kUm9ndWVU";
		buffer[54] = "b3VybkdldEFsbEFyY2hpdmVTY1JzcBD+LhITCg5DbWRMR0FDRU9GSkpCSxC1";
		buffer[55] = "LxItCihDbWRSb2d1ZVRvdXJuR2V0UGVybWFuZW50VGFsZW50SW5mb1NjUnNw";
		buffer[56] = "EKEvEh0KGENtZFJvZ3VlVG91cm5TZXR0bGVDc1JlcRD7LhIqCiVDbWRSb2d1";
		buffer[57] = "ZVRvdXJuR2V0U2Vhc29uVGFsZW50SW5mb1NjUnNwEK8vEikKJENtZFJvZ3Vl";
		buffer[58] = "VG91cm5FbmFibGVTZWFzb25UYWxlbnRTY1JzcBCFLxIpCiRDbWRSb2d1ZVRv";
		buffer[59] = "dXJuTGV2ZWxJbmZvVXBkYXRlU2NOb3RpZnkQqy8SLAonQ21kUm9ndWVUb3Vy";
		buffer[60] = "bkxlYXZlUm9ndWVDb2Nvb25TY2VuZVNjUnNwEMQvEi4KKUNtZFJvZ3VlVG91";
		buffer[61] = "cm5SZUVudGVyUm9ndWVDb2Nvb25TdGFnZVNjUnNwEP8uEiUKIENtZFJvZ3Vl";
		buffer[62] = "VG91cm5EZWxldGVCdWlsZFJlZkNzUmVxEIcvEisKJkNtZFJvZ3VlVG91cm5S";
		buffer[63] = "ZXNldFBlcm1hbmVudFRhbGVudFNjUnNwEM0vEiQKH0NtZFJvZ3VlVG91cm5B";
		buffer[64] = "cmVhVXBkYXRlU2NOb3RpZnkQoC8SHAoXQ21kUm9ndWVUb3VyblN0YXJ0Q3NS";
		buffer[65] = "ZXEQtC8SLAonQ21kUm9ndWVUb3VybkVuYWJsZVBlcm1hbmVudFRhbGVudFNj";
		buffer[66] = "UnNwEMIvEiwKJ0NtZFJvZ3VlVG91cm5HZXRDdXJSb2d1ZUNvY29vbkluZm9T";
		buffer[67] = "Y1JzcBD9LkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueTournType) }, null, null));
	}
}
