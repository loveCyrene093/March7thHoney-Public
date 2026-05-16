using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdGridFightTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdGridFightTypeReflection()
	{
		_003C_003Ey__InlineArray68<string> buffer = default(_003C_003Ey__InlineArray68<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 0) = "ChZDbWRHcmlkRmlnaHRUeXBlLnByb3RvKpYXChBDbWRHcmlkRmlnaHRUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 1) = "EhsKF0xKS0VKTEdETkpCX1BDUERIRUxQS0VNEAASIAobQ21kR3JpZEZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 2) = "R2V0QXJjaGl2ZVNjUnNwEIdCEhMKDkNtZEZJTU5JRlBGSEtEEPVCEhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 3) = "ZEJOT0tNTUdHREdQEI5EEh0KGENtZEdyaWRGaWdodEdldERhdGFTY1JzcBCu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 4) = "RBITCg5DbWRLRUtLSUVGS0tHTxD6QhITCg5DbWRDRU5MTklBT01BSxCHQxIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 5) = "Cg5DbWRHSk1JSUJERUFBShDOQxITCg5DbWRLTkhHSFBBQ0JNQxDzQhITCg5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 6) = "bWRETkRLT0lPSUJJThCnRBITCg5DbWRNTkJBQUdDR0lDThCqQhIcChdMSktF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 7) = "SkxHRE5KQl9JSUlEUE9HQUxJTBDqQxITCg5DbWRQUElES0NHSExPTxCmQxIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 8) = "ChtDbWRHcmlkRmlnaHRHZXRBcmNoaXZlQ3NSZXEQ60ESEwoOQ21kS0VEQU9J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 9) = "TkVFT0IQzkQSJgohQ21kR3JpZEZpZ2h0U3luY1ZpcnR1YWxJdGVtTm90aWZ5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 10) = "ELdCEiAKG0NtZEdyaWRGaWdodEVxdWlwQ3JhZnRDc1JlcRC4QxIcChdMSktF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 11) = "SkxHRE5KQl9IQkxOR0RISkhKShCMQxITCg5DbWRITE1HT0lCQUtQSBDbRBIq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 12) = "CiVDbWRHcmlkRmlnaHRXZWVrbHlFeHRyYVNlYXNvbkV4cFNjUnNwEMNEEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 13) = "DkNtZElCQkdJREFHQ09CEK1CEhMKDkNtZEVFQk1JQUZOSk1DEK5CEhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 14) = "ZEtNT0ZPT0dJRE9QEKJDEiEKHENtZEdyaWRGaWdodFJlY3ljbGVSb2xlU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 15) = "c3AQwkMSKwomQ21kR3JpZEZpZ2h0UGVybWFuZW50VGFsZW50RW5hYmxlQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 16) = "ZXEQoUQSHgoZQ21kR3JpZEZpZ2h0TG9ja1Nob3BDc1JlcRDHRBITCg5DbWRK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 17) = "Tk5OSkJBT0NPQhDVQxInCiJDbWRHcmlkRmlnaHRRdWl0TGVhdmVHYW1lUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 18) = "eUNzUmVxEIpCEhMKDkNtZE9LT0hFR0lCQ0NHEMRCEhMKDkNtZElOSERGRUlP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 19) = "Qk5LENxCEhMKDkNtZEVHTkxDTkpETkNLEPdCEhwKF0NtZEdyaWRGaWdodEJ1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 20) = "eUV4cENzUmVxEIREEiYKIUNtZEdyaWRGaWdodEVudGVyQmF0dGxlU3RhZ2VD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 21) = "c1JlcRC7QhITCg5DbWRHRE1JSUJOSkpFShCjRBImCiFDbWRHcmlkRmlnaHRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 22) = "dW1tb25Qcm9qZWN0aW9uQ3NSZXEQ6EISKgolQ21kR3JpZEZpZ2h0U2VsZWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 23) = "UmVjb21tZW5kRXF1aXBDc1JlcRDXQRITCg5DbWRDTUpDRUVEQ0lBThDSQxIm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 24) = "CiFDbWRHcmlkRmlnaHRVcGRhdGVFcXVpcFRyYWNrU2NSc3AQ3UMSHwoaQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 25) = "R3JpZEZpZ2h0VXBkYXRlUG9zQ3NSZXEQ1UESEwoOQ21kRVBKSkJOUElGTEMQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 26) = "50ISEwoOQ21kQ0VGSU1BREJJQkgQ7EISEwoOQ21kUERPQ0pLQkpOSFAQwkIS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 27) = "EwoOQ21kSFBNR0RGTUVJSkwQ4kISHAoXTEpLRUpMR0ROSkJfRkVKSkVBSUNF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 28) = "Tk8QmkQSHwoaQ21kR3JpZEZpZ2h0VXBkYXRlUG9zU2NSc3AQgkMSJQogQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 29) = "R3JpZEZpZ2h0RW5kQmF0dGxlU3RhZ2VOb3RpZnkQwkQSEwoOQ21kTkxJRERL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 30) = "SEpKRE8QmUQSJwoiQ21kR3JpZEZpZ2h0U2Vhc29uVGFsZW50UmVzZXRTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 31) = "cBDYQhITCg5DbWRESkNDQklPS05PRBDDQhITCg5DbWRGR0hIRElDTENKQhCZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 32) = "QhIkCh9DbWRHcmlkRmlnaHRSZXN1bWVHYW1lUGxheUNzUmVxELBEEhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 33) = "ZE9MT0dJQUxPSkRQEPhDEhMKDkNtZENDTkxITExJQVBMEPlDEhMKDkNtZEdD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 34) = "T0JFUE9HSFBMELNEEhoKFUNtZEZhdm91ckFyY2hpdmVTY1JzcBCJQxITCg5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 35) = "bWRFTUlEUENJSkFFThC+QxIcChdMSktFSkxHRE5KQl9OR0VOT05PT0VOQxC0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 36) = "RBIgChtDbWRHcmlkRmlnaHRFcXVpcERyZXNzQ3NSZXEQtkQSEwoOQ21kSE5F";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 37) = "SkhBSkpJT0IQlUISKQokQ21kR3JpZEZpZ2h0SGFuZGxlUGVuZGluZ0FjdGlv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 38) = "blNjUnNwEIpDEhMKDkNtZEFLSE9ESUlPR0RKEJJCEikKJENtZEdyaWRGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 39) = "dFN5bmNVcGRhdGVSZXN1bHRTY05vdGlmeRCIQhITCg5DbWREQ0hPS0pBRktK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 40) = "TxC6RBImCiFDbWRHcmlkRmlnaHRVcGRhdGVFcXVpcFRyYWNrQ3NSZXEQuEQS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 41) = "LgopQ21kR3JpZEZpZ2h0VXBkYXRlRXF1aXBUcmFja1ByaW9yaXR5Q3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 42) = "3UISIQocQ21kR3JpZEZpZ2h0UmVmcmVzaFNob3BDc1JlcRDUQxITCg5DbWRP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 43) = "TUpIUEhQUEFKSBC3RBIjCh5DbWRHcmlkRmlnaHRVc2VDb25zdW1hYmxlQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 44) = "ZXEQgEMSIQocQ21kR3JpZEZpZ2h0UmVjeWNsZVJvbGVDc1JlcRDDQxIrCiZD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 45) = "bWRHcmlkRmlnaHRQZXJtYW5lbnRUYWxlbnRFbmFibGVTY1JzcBD2QRIcChdM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 46) = "SktFSkxHRE5KQl9IQ1BQSUJESE9PSBDgQRIjCh5DbWRHcmlkRmlnaHRTdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 47) = "dEdhbWVQbGF5Q3NSZXEQx0ISIAobQ21kR3JpZEZpZ2h0UXVpdFNldHRsZUNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 48) = "UmVxEKBCEhMKDkNtZENPQ0hGSEtLRUJOENxEEh0KGENtZEdyaWRGaWdodFNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 49) = "dHRsZU5vdGlmeRDBQhITCg5DbWRHUEhPREtDUENIRxDbQRIkCh9DbWRHcmlk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 50) = "RmlnaHRGaW5pc2hUdXRvcmlhbENzUmVxEOxBEhwKF0xKS0VKTEdETkpCX0tO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 51) = "QkFQS0tKT0RIEIBEEiYKIUNtZEdyaWRGaWdodEVudGVyQmF0dGxlU3RhZ2VT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 52) = "Y1JzcBC5RBIcChdMSktFSkxHRE5KQl9QQklQTUdNQUJCThCDRBIoCiNDbWRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 53) = "cmlkRmlnaHRTZWFzb25UYWxlbnRFbmFibGVTY1JzcBCIRBITCg5DbWRESkNI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 54) = "Q0hDQUpQQhC9QhIhChxDbWRHcmlkRmlnaHRCYWNrVG9QcmVwYXJlUmVxEOBE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 55) = "EhMKDkNtZEhHT0lCREJNREJHEO5DEiUKIENtZEdyaWRGaWdodFN5bmNLZWVw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 56) = "V2luQ250Tm90aWZ5EL9EEigKI0NtZEdyaWRGaWdodFNlYXNvblRhbGVudEVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 57) = "YWJsZUNzUmVxELBCEioKJUNtZEdyaWRGaWdodFBlcm1hbmVudFRhbGVudFJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 58) = "c2V0Q3NSZXEQpEMSKgolQ21kR3JpZEZpZ2h0UGVybWFuZW50VGFsZW50UmVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 59) = "ZXRTY1JzcBDpQRIeChlDbWRHcmlkRmlnaHRCdXlHb29kc0NzUmVxEIZDEhoK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 60) = "FUNtZEZhdm91ckFyY2hpdmVDc1JlcRDSQhIeChlDbWRHcmlkRmlnaHRVc2VG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 61) = "b3JnZUNzUmVxEO9BEicKIkNtZEdyaWRGaWdodFNlYXNvblRhbGVudFJlc2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 62) = "Q3NSZXEQ80MSJgohQ21kR3JpZEZpZ2h0VGFrZVdlZWtseVJld2FyZENzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 63) = "EJBDEhMKDkNtZENFSUlFSE5EUEFKENhEEiUKIENtZEdyaWRGaWdodFNlYXNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 64) = "bkhhbmRCb29rTm90aWZ5EJ1DEhMKDkNtZEtNREhMRU5MSU1GELFEEikKJENt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 65) = "ZEdyaWRGaWdodERlc3Ryb3lXZWVrbHlSZXdhcmRDc1JlcRDZQhIdChhDbWRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 66) = "cmlkRmlnaHRHZXREYXRhQ3NSZXEQ90FCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray68<string>, string>(ref buffer, 67) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray68<string>, string>(in buffer, 68))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdGridFightType) }, null, null));
	}
}
