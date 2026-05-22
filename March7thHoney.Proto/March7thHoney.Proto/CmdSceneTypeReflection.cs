using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdSceneTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdSceneTypeReflection()
	{
		_003C_003Ey__InlineArray58<string> buffer = default(_003C_003Ey__InlineArray58<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 0) = "ChJDbWRTY2VuZVR5cGUucHJvdG8q4xMKDENtZFNjZW5lVHlwZRIbChdLSUxN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 1) = "SkxLT0tFSl9QQ1BESEVMUEtFTRAAEhMKDkNtZE9HSEVMTEFBRkpHEIwLEhwK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 2) = "F0NtZEdldEN1clNjZW5lSW5mb0NzUmVxEIELEiMKHkNtZFJlZnJlc2hUcmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 3) = "Z2VyQnlDbGllbnRTY1JzcBClCxIZChRDbWRFbnRlclNlY3Rpb25Dc1JlcRCx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 4) = "CxIcChdDbWRHZXRFbnRlcmVkU2NlbmVTY1JzcBCmCxIZChRDbWRFbnRlclNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 5) = "Y3Rpb25TY1JzcBCNCxITCg5DbWRDQk9GRkxQSElCUBCjCxIcChdDbWRHZXRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 6) = "Y2VuZU1hcEluZm9TY1JzcBDbCxIcChdDbWRTY2VuZUVudGl0eU1vdmVDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 7) = "cRD6ChIfChpDbWRTY2VuZUVudGl0eU1vdmVTY05vdGlmeRCfCxImCiFDbWRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 8) = "Y2VuZUNhc3RTa2lsbE1wVXBkYXRlU2NOb3RpZnkQngsSJgohQ21kUmVmcmVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 9) = "aFRyaWdnZXJCeUNsaWVudFNjTm90aWZ5EM8LEhgKE0NtZENvdW50ZXJEb3du";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 10) = "Q3NSZXEQzgsSHgoZQ21kQWN0aXZlRmFybUVsZW1lbnRTY1JzcBCWCxIgChtD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 11) = "bWRVcGRhdGVHcm91cFByb3BlcnR5Q3NSZXEQjgsSGwoWQ21kQ291bnRlclJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 12) = "Y292ZXJDc1JlcRCgCxIeChlDbWRHZXRVbmxvY2tUZWxlcG9ydFNjUnNwEMsL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 13) = "EhMKDkNtZEdMTENGQUxGQ09DELgLEhwKF0tJTE1KTEtPS0VKX0NEUEJJRlBI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 14) = "RUdFEP8KEiUKIENtZFNjZW5lUmV2aXZlQWZ0ZXJSZWJhdHRsZUNzUmVxENEL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 15) = "EhwKF0NtZFNjZW5lRW50ZXJTdGFnZUNzUmVxEKQLEhMKDkNtZEZCSkRGR01N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 16) = "TUZQEM0LEiMKHkNtZFVwZGF0ZUZsb29yU2F2ZWRWYWx1ZU5vdGlmeRCHCxIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 17) = "Cg5DbWRCRE9OQkhCUEpNQxDVCxITCg5DbWRQR0pNTEFBS0RKRhCyCxIhChxD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 18) = "bWRTY2VuZUNhc3RTa2lsbENvc3RNcENzUmVxEJ0LEh0KGENtZFN0YXJ0Q29j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 19) = "b29uU3RhZ2VDc1JlcRCRCxIfChpDbWRTY2VuZVBsYW5lRXZlbnRTY05vdGlm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 20) = "eRDKCxIjCh5DbWRSZWZyZXNoVHJpZ2dlckVudGl0eUxpc3RSZXEQsAsSHAoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 21) = "Q21kU2V0VHJhaW5Xb3JsZElkQ3NSZXEQiwsSHgoZQ21kQWN0aXZlRmFybUVs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 22) = "ZW1lbnRDc1JlcRCDCxIcChdDbWRTY2VuZUVudGVyU3RhZ2VTY1JzcBDcCxIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 23) = "Cg5DbWRPRkdLTkdQREZJSxCoCxIiCh1DbWRUcmFpbldvcmxkSWRDaGFuZ2VT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 24) = "Y05vdGlmeRCqCxIcChdDbWRTYXZlUG9pbnRzSW5mb05vdGlmeRCrCxIgChtD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 25) = "bWRTY2VuZUVudGl0eVRlbGVwb3J0Q3NSZXEQvQsSHAoXQ21kU2V0VHJhaW5X";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 26) = "b3JsZElkU2NSc3AQpwsSFwoSQ21kRW50ZXJTY2VuZVNjUnNwEL4LEiQKH0Nt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 27) = "ZFJlRW50ZXJMYXN0RWxlbWVudFN0YWdlU2NSc3AQ0gsSHAoXQ21kU2NlbmVF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 28) = "bnRpdHlNb3ZlU2NSc3AQggsSHAoXQ21kVW5sb2NrVGVsZXBvcnROb3RpZnkQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 29) = "zAsSHQoYQ21kR3JvdXBTdGF0ZUNoYW5nZUNzUmVxENkLEhMKDkNtZE5CUEFH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 30) = "SkJMS0pGEIQLEiMKHkNtZFNldEdyb3VwQ3VzdG9tU2F2ZURhdGFTY1JzcBCI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 31) = "CxIZChRDbWRPcGVuQ2hlc3RTY05vdGlmeRCbCxIeChlDbWRHZXRVbmxvY2tU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 32) = "ZWxlcG9ydENzUmVxEJcLEhMKDkNtZExNSEhGTEtDUFBGEIkLEhwKF0tJTE1K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 33) = "TEtPS0VKX05GREhGTU9PSkFPEMELEhMKDkNtZEtDSk5JUE1LQ0dCELsLEhwK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 34) = "F0tJTE1KTEtPS0VKX0dDS09DSUxDRUFDEMcLEiMKHkNtZFNjZW5lQ2hlY2tw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 35) = "b2luZ1JlZnJlc2hTY1JzcBCZCxITCg5DbWRHUEFDS1BKSkdCShDICxIiCh1D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 36) = "bWREZWFjdGl2YXRlRmFybUVsZW1lbnRDc1JlcRC6CxITCg5DbWRHRUpFT0NC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 37) = "RlBNQRD5ChITCg5DbWRDSEFQREdEREtCSxCtCxIoCiNDbWRTY2VuZUNoZWNr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 38) = "cG9pbnRSZWZyZXNoTW9uc3RlclJlcRCYCxITCg5DbWROR1BPRkdQRURDShDY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 39) = "CxIZChRDbWRJbnRlcmFjdFByb3BTY1JzcBDXCxITCg5DbWRISUFCTU9OTk5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 40) = "ShD9ChIbChZDbWRTY2VuZUNhc3RTa2lsbENzUmVxEIYLEiIKHUNtZEVudGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 41) = "ZWRTY2VuZUNoYW5nZVNjTm90aWZ5EJoLEhMKDkNtZEhIR0NJR0JOTUVQEMML";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 42) = "EiEKHENtZFNjZW5lQ2FzdFNraWxsQ29zdE1wU2NSc3AQ/AoSEwoOQ21kUEZB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 43) = "QkZLT05BSU0QjwsSHAoXQ21kR2V0Q3VyU2NlbmVJbmZvU2NSc3AQ2gsSIgod";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 44) = "Q21kRW50ZXJTY2VuZUJ5U2VydmVyU2NOb3RpZnkQvAsSHAoXS0lMTUpMS09L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 45) = "RUpfTE5HRE1GSVBBQ0oQxQsSHAoXQ21kR2V0U2NlbmVNYXBJbmZvQ3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 46) = "tAsSGwoWQ21kU2NlbmVDYXN0U2tpbGxTY1JzcBCKCxIXChJDbWRFbnRlclNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 47) = "ZW5lQ3NSZXEQtgsSIAobQ21kU2NlbmVFbnRpdHlUZWxlcG9ydFNjUnNwEKEL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 48) = "EhMKDkNtZE5FTkpLREVEUEpKEJILEhMKDkNtZE1CTUFDQ0xIRUJLEJQLEiAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 49) = "G0NtZFN5bmNFbnRpdHlCdWZmQ2hhbmdlTGlzdBDCCxIkCh9DbWRSZUVudGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 50) = "TGFzdEVsZW1lbnRTdGFnZUNzUmVxEKwLEh0KGENtZERlbGV0ZVN1bW1vblVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 51) = "aXRDc1JlcRCTCxIfChpDbWRDaGFuZ2VUaW1lUmV3aW5kSW5mb1JlcRC3CxIZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 52) = "ChRDbWRJbnRlcmFjdFByb3BDc1JlcRDWCxIhChxDbWRTY2VuZUdyb3VwUmVm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 53) = "cmVzaFNjTm90aWZ5EK8LEhMKDkNtZEpCR0FOQkFFRFBNEIULEhMKDkNtZEtK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 54) = "QU1QS0JQQU9MELULEhwKF0tJTE1KTEtPS0VKX0NLUEhCQUxIQUxMENMLEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 55) = "DkNtZE5BRkNMREFCR0xDEIALEhwKF0NtZEdldEVudGVyZWRTY2VuZUNzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 56) = "EMQLEh0KGENtZFN0YXJ0Q29jb29uU3RhZ2VTY1JzcBCuC0IWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray58<string>, string>(ref buffer, 57) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray58<string>, string>(in buffer, 58))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdSceneType) }, null, null));
	}
}
