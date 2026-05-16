using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdChimeraDuelTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdChimeraDuelTypeReflection()
	{
		_003C_003Ey__InlineArray33<string> buffer = default(_003C_003Ey__InlineArray33<string>);
		buffer[0] = "ChhDbWRDaGltZXJhRHVlbFR5cGUucHJvdG8q8goKEkNtZENoaW1lcmFEdWVs";
		buffer[1] = "VHlwZRIbChdNTkdKR0dBTklJUF9QQ1BESEVMUEtFTRAAEiEKHENtZENoaW1l";
		buffer[2] = "cmFEdWVsU3RhcnRHYW1lU2NSc3AQ+0cSKQokQ21kQ2hpbWVyYUR1ZWxFbmRS";
		buffer[3] = "b3VuZFNob3BTdGFnZVNjUnNwEI1IEiIKHUNtZENoaW1lcmFEdWVsU2VsZWN0";
		buffer[4] = "R2FtZUNzUmVxEP5HEisKJkNtZENoaW1lcmFEdWVsRW5kUm91bmRCYXR0bGVT";
		buffer[5] = "dGFnZUNzUmVxEPxHEi0KKENtZENoaW1lcmFEdWVsRmluaXNoTWFzdGVyQ2hh";
		buffer[6] = "bGxlbmdlQ3NSZXEQqEgSIAobQ21kQ2hpbWVyYUR1ZWxTaG9wTG9ja0NzUmVx";
		buffer[7] = "EJlIEikKJENtZENoaW1lcmFEdWVsRW5kUm91bmRTaG9wU3RhZ2VDc1JlcRCp";
		buffer[8] = "SBIhChxDbWRDaGltZXJhRHVlbFN0YXJ0R2FtZUNzUmVxEP9HEh8KGkNtZENo";
		buffer[9] = "aW1lcmFEdWVsR2V0RGF0YUNzUmVxEIdIEh8KGkNtZENoaW1lcmFEdWVsRW5k";
		buffer[10] = "R2FtZUNzUmVxEIxIEiMKHkNtZENoaW1lcmFEdWVsU2hvcEJ1eUl0ZW1TY1Jz";
		buffer[11] = "cBCKSBIkCh9DbWRDaGltZXJhRHVlbFVubG9ja01hc3RlckNzUmVxEJ1IEiMK";
		buffer[12] = "HkNtZENoaW1lcmFEdWVsU2VsbENoaW1lcmFTY1JzcBCDSBIjCh5DbWRDaGlt";
		buffer[13] = "ZXJhRHVlbFNlbGxDaGltZXJhQ3NSZXEQm0gSKwomQ21kQ2hpbWVyYUR1ZWxF";
		buffer[14] = "bmRSb3VuZEJhdHRsZVN0YWdlU2NSc3AQpkgSJgohQ21kQ2hpbWVyYUR1ZWxT";
		buffer[15] = "aG9wQnV5Q2hpbWVyYUNzUmVxEJ5IEg8KCkNtZFJlY2VpdmUQkEgSJgohQ21k";
		buffer[16] = "Q2hpbWVyYUR1ZWxTaG9wQnV5Q2hpbWVyYVNjUnNwEP1HEi0KKENtZENoaW1l";
		buffer[17] = "cmFEdWVsU2V0RnJpZW5kRGVmZW5kTGluZXVwQ3NSZXEQpUgSKwomQ21kQ2hp";
		buffer[18] = "bWVyYUR1ZWxTYXZlRnJpZW5kUHZwTGluZXVwQ3NSZXEQqkgSJAofQ21kQ2hp";
		buffer[19] = "bWVyYUR1ZWxDaGFuZ2VMaW5ldXBDc1JlcRCUSBIlCiBDbWRDaGltZXJhRHVl";
		buffer[20] = "bEdldEZyaWVuZExpc3RDc1JlcRCOSBIjCh5DbWRDaGltZXJhRHVlbFNob3BS";
		buffer[21] = "ZWZyZXNoQ3NSZXEQq0gSHwoaQ21kQ2hpbWVyYUR1ZWxHZXREYXRhU2NSc3AQ";
		buffer[22] = "gUgSIAobQ21kQ2hpbWVyYUR1ZWxTaG9wTG9ja1NjUnNwEI9IEisKJkNtZENo";
		buffer[23] = "aW1lcmFEdWVsU2F2ZUZyaWVuZFB2cExpbmV1cFNjUnNwEJdIEiQKH0NtZENo";
		buffer[24] = "aW1lcmFEdWVsQ2hhbmdlTGluZXVwU2NSc3AQgkgSIwoeQ21kQ2hpbWVyYUR1";
		buffer[25] = "ZWxTaG9wQnV5SXRlbUNzUmVxEKxIEi0KKENtZENoaW1lcmFEdWVsU2V0RnJp";
		buffer[26] = "ZW5kRGVmZW5kTGluZXVwU2NSc3AQoUgSJQogQ21kQ2hpbWVyYUR1ZWxTeW5j";
		buffer[27] = "Q2hhbmdlU2NOb3RpZnkQgEgSLQooQ21kQ2hpbWVyYUR1ZWxGaW5pc2hNYXN0";
		buffer[28] = "ZXJDaGFsbGVuZ2VTY1JzcBCiSBIiCh1DbWRDaGltZXJhRHVlbFNlbGVjdEdh";
		buffer[29] = "bWVTY1JzcBCfSBIjCh5DbWRDaGltZXJhRHVlbFNob3BSZWZyZXNoU2NSc3AQ";
		buffer[30] = "iUgSHwoaQ21kQ2hpbWVyYUR1ZWxFbmRHYW1lU2NSc3AQp0gSJAofQ21kQ2hp";
		buffer[31] = "bWVyYUR1ZWxVbmxvY2tNYXN0ZXJTY1JzcBCgSEIWqgITTWFyY2g3dGhIb25l";
		buffer[32] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChimeraDuelType) }, null, null));
	}
}
