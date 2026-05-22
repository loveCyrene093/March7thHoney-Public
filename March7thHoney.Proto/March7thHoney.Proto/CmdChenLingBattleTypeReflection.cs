using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdChenLingBattleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdChenLingBattleTypeReflection()
	{
		_003C_003Ey__InlineArray28<string> buffer = default(_003C_003Ey__InlineArray28<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 0) = "ChtDbWRDaGVuTGluZ0JhdHRsZVR5cGUucHJvdG8qngkKFUNtZENoZW5MaW5n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 1) = "QmF0dGxlVHlwZRIbChdCRUxOSURJRElLT19QQ1BESEVMUEtFTRAAEh8KGkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 2) = "ZENoZW5MaW5nTW92ZUVudGl0eUNzUmVxEJBLEiAKG0NtZENoZW5MaW5nUmVm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 3) = "cmVzaENhcmRDc1JlcRCUSxIfChpDbWRDaGVuTGluZ1VubG9ja0dyaWRDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 4) = "cRDnShIiCh1DbWRDaGVuTGluZ0ZpbmlzaFByZXBhcmVDc1JlcRD0ShITCg5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 5) = "bWROTktMR1BKQUZQShD3ShIhChxDbWRDaGVuTGluZ0ZpbmlzaEJhdHRsZUNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 6) = "UmVxEIZLEiEKHENtZENoZW5MaW5nU2VsbEhhbmRDYXJkQ3NSZXEQ5EoSHwoa";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 7) = "Q21kQ2hlbkxpbmdGaW5pc2hTaG9wQ3NSZXEQjUsSEwoOQ21kSEFLSEdIQUZO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 8) = "RUUQjksSEwoOQ21kS0xKRU5DQUVEQkgQiksSIAobQ21kQ2hlbkxpbmdVc2VI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 9) = "YW5kQ2FyZENzUmVxEJFLEh4KGUNtZENoZW5MaW5nUXVpdFN0YWdlU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 10) = "iEsSIAobQ21kQ2hlbkxpbmdCdXlTaG9wSXRlbUNzUmVxEOtKEhMKDkNtZEFJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 11) = "SUtJTE1OSUZJEPVKEhMKDkNtZEFMR01DRkJISkJJEINLEhMKDkNtZEFBREhF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 12) = "TExPQkNDEIlLEhMKDkNtZE1GTk9FT0VERkRGEPxKEiIKHUNtZENoZW5MaW5n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 13) = "U3luY0NoYW5nZVNjTm90aWZ5EP9KEh8KGkNtZENoZW5MaW5nU2VsZWN0Q2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 14) = "ZENzUmVxEOhKEhMKDkNtZExBSkVFQUVOS0RJEPFKEhMKDkNtZEtGSkZDS1BN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 15) = "RE5IEP5KEhwKF0NtZENoZW5MaW5nR2V0RGF0YUNzUmVxEO9KEiEKHENtZENo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 16) = "ZW5MaW5nU2VsZWN0UG9saWN5Q3NSZXEQ6koSHwoaQ21kQ2hlbkxpbmdTdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 17) = "dFN0YWdlU2NSc3AQ/UoSEwoOQ21kR0lQS09HTEdITEIQ5koSHgoZQ21kQ2hl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 18) = "bkxpbmdSZWZyZXNoU2hvcFJlcRCTSxIfChpDbWRDaGVuTGluZ1N0YXJ0U3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 19) = "Z2VDc1JlcRCASxITCg5DbWRDQ0VIR0RQRkdJThDyShITCg5DbWRPTEpDRUxO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 20) = "RUxPSBCPSxITCg5DbWRGTk5OS0lKUE1JSRDjShITCg5DbWRNTkxLTEZDRFBD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 21) = "RxDzShIiCh1DbWRDaGVuTGluZ1JlZnJlc2hQb2xpY3lDc1JlcRCBSxITCg5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 22) = "bWRQSEdDRlBOQ0RCRRD4ShIpCiRDbWRDaGVuTGluZ0hhbmRsZVBlbmRpbmdB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 23) = "Y3Rpb25zQ3NSZXEQ9koSEwoOQ21kQ0JERVBIR0VQSkoQ5UoSJwoiQ21kQ2hl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 24) = "bkxpbmdBY3RpdmF0ZWRQcml2aWxlZ2VDc1JlcRCHSxIeChlDbWRDaGVuTGlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 25) = "Z1F1aXRTdGFnZUNzUmVxEIVLEicKIkNtZENoZW5MaW5nQWN0aXZhdGVkUHJp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 26) = "dmlsZWdlU2NSc3AQkksSHAoXQ21kQ2hlbkxpbmdHZXREYXRhU2NSc3AQ6UpC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray28<string>, string>(ref buffer, 27) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray28<string>, string>(in buffer, 28))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChenLingBattleType) }, null, null));
	}
}
