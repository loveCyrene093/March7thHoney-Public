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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 0) = "ChhDbWRDaGltZXJhRHVlbFR5cGUucHJvdG8q8goKEkNtZENoaW1lcmFEdWVs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 1) = "VHlwZRIbChdNTkdKR0dBTklJUF9QQ1BESEVMUEtFTRAAEiEKHENtZENoaW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 2) = "cmFEdWVsU3RhcnRHYW1lU2NSc3AQ+0cSKQokQ21kQ2hpbWVyYUR1ZWxFbmRS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 3) = "b3VuZFNob3BTdGFnZVNjUnNwEI1IEiIKHUNtZENoaW1lcmFEdWVsU2VsZWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 4) = "R2FtZUNzUmVxEP5HEisKJkNtZENoaW1lcmFEdWVsRW5kUm91bmRCYXR0bGVT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 5) = "dGFnZUNzUmVxEPxHEi0KKENtZENoaW1lcmFEdWVsRmluaXNoTWFzdGVyQ2hh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 6) = "bGxlbmdlQ3NSZXEQqEgSIAobQ21kQ2hpbWVyYUR1ZWxTaG9wTG9ja0NzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 7) = "EJlIEikKJENtZENoaW1lcmFEdWVsRW5kUm91bmRTaG9wU3RhZ2VDc1JlcRCp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 8) = "SBIhChxDbWRDaGltZXJhRHVlbFN0YXJ0R2FtZUNzUmVxEP9HEh8KGkNtZENo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 9) = "aW1lcmFEdWVsR2V0RGF0YUNzUmVxEIdIEh8KGkNtZENoaW1lcmFEdWVsRW5k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 10) = "R2FtZUNzUmVxEIxIEiMKHkNtZENoaW1lcmFEdWVsU2hvcEJ1eUl0ZW1TY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 11) = "cBCKSBIkCh9DbWRDaGltZXJhRHVlbFVubG9ja01hc3RlckNzUmVxEJ1IEiMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 12) = "HkNtZENoaW1lcmFEdWVsU2VsbENoaW1lcmFTY1JzcBCDSBIjCh5DbWRDaGlt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 13) = "ZXJhRHVlbFNlbGxDaGltZXJhQ3NSZXEQm0gSKwomQ21kQ2hpbWVyYUR1ZWxF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 14) = "bmRSb3VuZEJhdHRsZVN0YWdlU2NSc3AQpkgSJgohQ21kQ2hpbWVyYUR1ZWxT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 15) = "aG9wQnV5Q2hpbWVyYUNzUmVxEJ5IEg8KCkNtZFJlY2VpdmUQkEgSJgohQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 16) = "Q2hpbWVyYUR1ZWxTaG9wQnV5Q2hpbWVyYVNjUnNwEP1HEi0KKENtZENoaW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 17) = "cmFEdWVsU2V0RnJpZW5kRGVmZW5kTGluZXVwQ3NSZXEQpUgSKwomQ21kQ2hp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 18) = "bWVyYUR1ZWxTYXZlRnJpZW5kUHZwTGluZXVwQ3NSZXEQqkgSJAofQ21kQ2hp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 19) = "bWVyYUR1ZWxDaGFuZ2VMaW5ldXBDc1JlcRCUSBIlCiBDbWRDaGltZXJhRHVl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 20) = "bEdldEZyaWVuZExpc3RDc1JlcRCOSBIjCh5DbWRDaGltZXJhRHVlbFNob3BS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 21) = "ZWZyZXNoQ3NSZXEQq0gSHwoaQ21kQ2hpbWVyYUR1ZWxHZXREYXRhU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 22) = "gUgSIAobQ21kQ2hpbWVyYUR1ZWxTaG9wTG9ja1NjUnNwEI9IEisKJkNtZENo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 23) = "aW1lcmFEdWVsU2F2ZUZyaWVuZFB2cExpbmV1cFNjUnNwEJdIEiQKH0NtZENo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 24) = "aW1lcmFEdWVsQ2hhbmdlTGluZXVwU2NSc3AQgkgSIwoeQ21kQ2hpbWVyYUR1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 25) = "ZWxTaG9wQnV5SXRlbUNzUmVxEKxIEi0KKENtZENoaW1lcmFEdWVsU2V0RnJp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 26) = "ZW5kRGVmZW5kTGluZXVwU2NSc3AQoUgSJQogQ21kQ2hpbWVyYUR1ZWxTeW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 27) = "Q2hhbmdlU2NOb3RpZnkQgEgSLQooQ21kQ2hpbWVyYUR1ZWxGaW5pc2hNYXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 28) = "ZXJDaGFsbGVuZ2VTY1JzcBCiSBIiCh1DbWRDaGltZXJhRHVlbFNlbGVjdEdh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 29) = "bWVTY1JzcBCfSBIjCh5DbWRDaGltZXJhRHVlbFNob3BSZWZyZXNoU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 30) = "iUgSHwoaQ21kQ2hpbWVyYUR1ZWxFbmRHYW1lU2NSc3AQp0gSJAofQ21kQ2hp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 31) = "bWVyYUR1ZWxVbmxvY2tNYXN0ZXJTY1JzcBCgSEIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 32) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray33<string>, string>(in buffer, 33))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChimeraDuelType) }, null, null));
	}
}
