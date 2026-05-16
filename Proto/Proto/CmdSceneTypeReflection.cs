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
		buffer[0] = "ChJDbWRTY2VuZVR5cGUucHJvdG8q4xMKDENtZFNjZW5lVHlwZRIbChdLSUxN";
		buffer[1] = "SkxLT0tFSl9QQ1BESEVMUEtFTRAAEhMKDkNtZE9HSEVMTEFBRkpHEIwLEhwK";
		buffer[2] = "F0NtZEdldEN1clNjZW5lSW5mb0NzUmVxEIELEiMKHkNtZFJlZnJlc2hUcmln";
		buffer[3] = "Z2VyQnlDbGllbnRTY1JzcBClCxIZChRDbWRFbnRlclNlY3Rpb25Dc1JlcRCx";
		buffer[4] = "CxIcChdDbWRHZXRFbnRlcmVkU2NlbmVTY1JzcBCmCxIZChRDbWRFbnRlclNl";
		buffer[5] = "Y3Rpb25TY1JzcBCNCxITCg5DbWRDQk9GRkxQSElCUBCjCxIcChdDbWRHZXRT";
		buffer[6] = "Y2VuZU1hcEluZm9TY1JzcBDbCxIcChdDbWRTY2VuZUVudGl0eU1vdmVDc1Jl";
		buffer[7] = "cRD6ChIfChpDbWRTY2VuZUVudGl0eU1vdmVTY05vdGlmeRCfCxImCiFDbWRT";
		buffer[8] = "Y2VuZUNhc3RTa2lsbE1wVXBkYXRlU2NOb3RpZnkQngsSJgohQ21kUmVmcmVz";
		buffer[9] = "aFRyaWdnZXJCeUNsaWVudFNjTm90aWZ5EM8LEhgKE0NtZENvdW50ZXJEb3du";
		buffer[10] = "Q3NSZXEQzgsSHgoZQ21kQWN0aXZlRmFybUVsZW1lbnRTY1JzcBCWCxIgChtD";
		buffer[11] = "bWRVcGRhdGVHcm91cFByb3BlcnR5Q3NSZXEQjgsSGwoWQ21kQ291bnRlclJl";
		buffer[12] = "Y292ZXJDc1JlcRCgCxIeChlDbWRHZXRVbmxvY2tUZWxlcG9ydFNjUnNwEMsL";
		buffer[13] = "EhMKDkNtZEdMTENGQUxGQ09DELgLEhwKF0tJTE1KTEtPS0VKX0NEUEJJRlBI";
		buffer[14] = "RUdFEP8KEiUKIENtZFNjZW5lUmV2aXZlQWZ0ZXJSZWJhdHRsZUNzUmVxENEL";
		buffer[15] = "EhwKF0NtZFNjZW5lRW50ZXJTdGFnZUNzUmVxEKQLEhMKDkNtZEZCSkRGR01N";
		buffer[16] = "TUZQEM0LEiMKHkNtZFVwZGF0ZUZsb29yU2F2ZWRWYWx1ZU5vdGlmeRCHCxIT";
		buffer[17] = "Cg5DbWRCRE9OQkhCUEpNQxDVCxITCg5DbWRQR0pNTEFBS0RKRhCyCxIhChxD";
		buffer[18] = "bWRTY2VuZUNhc3RTa2lsbENvc3RNcENzUmVxEJ0LEh0KGENtZFN0YXJ0Q29j";
		buffer[19] = "b29uU3RhZ2VDc1JlcRCRCxIfChpDbWRTY2VuZVBsYW5lRXZlbnRTY05vdGlm";
		buffer[20] = "eRDKCxIjCh5DbWRSZWZyZXNoVHJpZ2dlckVudGl0eUxpc3RSZXEQsAsSHAoX";
		buffer[21] = "Q21kU2V0VHJhaW5Xb3JsZElkQ3NSZXEQiwsSHgoZQ21kQWN0aXZlRmFybUVs";
		buffer[22] = "ZW1lbnRDc1JlcRCDCxIcChdDbWRTY2VuZUVudGVyU3RhZ2VTY1JzcBDcCxIT";
		buffer[23] = "Cg5DbWRPRkdLTkdQREZJSxCoCxIiCh1DbWRUcmFpbldvcmxkSWRDaGFuZ2VT";
		buffer[24] = "Y05vdGlmeRCqCxIcChdDbWRTYXZlUG9pbnRzSW5mb05vdGlmeRCrCxIgChtD";
		buffer[25] = "bWRTY2VuZUVudGl0eVRlbGVwb3J0Q3NSZXEQvQsSHAoXQ21kU2V0VHJhaW5X";
		buffer[26] = "b3JsZElkU2NSc3AQpwsSFwoSQ21kRW50ZXJTY2VuZVNjUnNwEL4LEiQKH0Nt";
		buffer[27] = "ZFJlRW50ZXJMYXN0RWxlbWVudFN0YWdlU2NSc3AQ0gsSHAoXQ21kU2NlbmVF";
		buffer[28] = "bnRpdHlNb3ZlU2NSc3AQggsSHAoXQ21kVW5sb2NrVGVsZXBvcnROb3RpZnkQ";
		buffer[29] = "zAsSHQoYQ21kR3JvdXBTdGF0ZUNoYW5nZUNzUmVxENkLEhMKDkNtZE5CUEFH";
		buffer[30] = "SkJMS0pGEIQLEiMKHkNtZFNldEdyb3VwQ3VzdG9tU2F2ZURhdGFTY1JzcBCI";
		buffer[31] = "CxIZChRDbWRPcGVuQ2hlc3RTY05vdGlmeRCbCxIeChlDbWRHZXRVbmxvY2tU";
		buffer[32] = "ZWxlcG9ydENzUmVxEJcLEhMKDkNtZExNSEhGTEtDUFBGEIkLEhwKF0tJTE1K";
		buffer[33] = "TEtPS0VKX05GREhGTU9PSkFPEMELEhMKDkNtZEtDSk5JUE1LQ0dCELsLEhwK";
		buffer[34] = "F0tJTE1KTEtPS0VKX0dDS09DSUxDRUFDEMcLEiMKHkNtZFNjZW5lQ2hlY2tw";
		buffer[35] = "b2luZ1JlZnJlc2hTY1JzcBCZCxITCg5DbWRHUEFDS1BKSkdCShDICxIiCh1D";
		buffer[36] = "bWREZWFjdGl2YXRlRmFybUVsZW1lbnRDc1JlcRC6CxITCg5DbWRHRUpFT0NC";
		buffer[37] = "RlBNQRD5ChITCg5DbWRDSEFQREdEREtCSxCtCxIoCiNDbWRTY2VuZUNoZWNr";
		buffer[38] = "cG9pbnRSZWZyZXNoTW9uc3RlclJlcRCYCxITCg5DbWROR1BPRkdQRURDShDY";
		buffer[39] = "CxIZChRDbWRJbnRlcmFjdFByb3BTY1JzcBDXCxITCg5DbWRISUFCTU9OTk5B";
		buffer[40] = "ShD9ChIbChZDbWRTY2VuZUNhc3RTa2lsbENzUmVxEIYLEiIKHUNtZEVudGVy";
		buffer[41] = "ZWRTY2VuZUNoYW5nZVNjTm90aWZ5EJoLEhMKDkNtZEhIR0NJR0JOTUVQEMML";
		buffer[42] = "EiEKHENtZFNjZW5lQ2FzdFNraWxsQ29zdE1wU2NSc3AQ/AoSEwoOQ21kUEZB";
		buffer[43] = "QkZLT05BSU0QjwsSHAoXQ21kR2V0Q3VyU2NlbmVJbmZvU2NSc3AQ2gsSIgod";
		buffer[44] = "Q21kRW50ZXJTY2VuZUJ5U2VydmVyU2NOb3RpZnkQvAsSHAoXS0lMTUpMS09L";
		buffer[45] = "RUpfTE5HRE1GSVBBQ0oQxQsSHAoXQ21kR2V0U2NlbmVNYXBJbmZvQ3NSZXEQ";
		buffer[46] = "tAsSGwoWQ21kU2NlbmVDYXN0U2tpbGxTY1JzcBCKCxIXChJDbWRFbnRlclNj";
		buffer[47] = "ZW5lQ3NSZXEQtgsSIAobQ21kU2NlbmVFbnRpdHlUZWxlcG9ydFNjUnNwEKEL";
		buffer[48] = "EhMKDkNtZE5FTkpLREVEUEpKEJILEhMKDkNtZE1CTUFDQ0xIRUJLEJQLEiAK";
		buffer[49] = "G0NtZFN5bmNFbnRpdHlCdWZmQ2hhbmdlTGlzdBDCCxIkCh9DbWRSZUVudGVy";
		buffer[50] = "TGFzdEVsZW1lbnRTdGFnZUNzUmVxEKwLEh0KGENtZERlbGV0ZVN1bW1vblVu";
		buffer[51] = "aXRDc1JlcRCTCxIfChpDbWRDaGFuZ2VUaW1lUmV3aW5kSW5mb1JlcRC3CxIZ";
		buffer[52] = "ChRDbWRJbnRlcmFjdFByb3BDc1JlcRDWCxIhChxDbWRTY2VuZUdyb3VwUmVm";
		buffer[53] = "cmVzaFNjTm90aWZ5EK8LEhMKDkNtZEpCR0FOQkFFRFBNEIULEhMKDkNtZEtK";
		buffer[54] = "QU1QS0JQQU9MELULEhwKF0tJTE1KTEtPS0VKX0NLUEhCQUxIQUxMENMLEhMK";
		buffer[55] = "DkNtZE5BRkNMREFCR0xDEIALEhwKF0NtZEdldEVudGVyZWRTY2VuZUNzUmVx";
		buffer[56] = "EMQLEh0KGENtZFN0YXJ0Q29jb29uU3RhZ2VTY1JzcBCuC0IWqgITTWFyY2g3";
		buffer[57] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdSceneType) }, null, null));
	}
}
