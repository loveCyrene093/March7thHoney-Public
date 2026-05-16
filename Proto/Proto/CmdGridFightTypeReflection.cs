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
		buffer[0] = "ChZDbWRHcmlkRmlnaHRUeXBlLnByb3RvKpYXChBDbWRHcmlkRmlnaHRUeXBl";
		buffer[1] = "EhsKF0xKS0VKTEdETkpCX1BDUERIRUxQS0VNEAASIAobQ21kR3JpZEZpZ2h0";
		buffer[2] = "R2V0QXJjaGl2ZVNjUnNwEIdCEhMKDkNtZEZJTU5JRlBGSEtEEPVCEhMKDkNt";
		buffer[3] = "ZEJOT0tNTUdHREdQEI5EEh0KGENtZEdyaWRGaWdodEdldERhdGFTY1JzcBCu";
		buffer[4] = "RBITCg5DbWRLRUtLSUVGS0tHTxD6QhITCg5DbWRDRU5MTklBT01BSxCHQxIT";
		buffer[5] = "Cg5DbWRHSk1JSUJERUFBShDOQxITCg5DbWRLTkhHSFBBQ0JNQxDzQhITCg5D";
		buffer[6] = "bWRETkRLT0lPSUJJThCnRBITCg5DbWRNTkJBQUdDR0lDThCqQhIcChdMSktF";
		buffer[7] = "SkxHRE5KQl9JSUlEUE9HQUxJTBDqQxITCg5DbWRQUElES0NHSExPTxCmQxIg";
		buffer[8] = "ChtDbWRHcmlkRmlnaHRHZXRBcmNoaXZlQ3NSZXEQ60ESEwoOQ21kS0VEQU9J";
		buffer[9] = "TkVFT0IQzkQSJgohQ21kR3JpZEZpZ2h0U3luY1ZpcnR1YWxJdGVtTm90aWZ5";
		buffer[10] = "ELdCEiAKG0NtZEdyaWRGaWdodEVxdWlwQ3JhZnRDc1JlcRC4QxIcChdMSktF";
		buffer[11] = "SkxHRE5KQl9IQkxOR0RISkhKShCMQxITCg5DbWRITE1HT0lCQUtQSBDbRBIq";
		buffer[12] = "CiVDbWRHcmlkRmlnaHRXZWVrbHlFeHRyYVNlYXNvbkV4cFNjUnNwEMNEEhMK";
		buffer[13] = "DkNtZElCQkdJREFHQ09CEK1CEhMKDkNtZEVFQk1JQUZOSk1DEK5CEhMKDkNt";
		buffer[14] = "ZEtNT0ZPT0dJRE9QEKJDEiEKHENtZEdyaWRGaWdodFJlY3ljbGVSb2xlU2NS";
		buffer[15] = "c3AQwkMSKwomQ21kR3JpZEZpZ2h0UGVybWFuZW50VGFsZW50RW5hYmxlQ3NS";
		buffer[16] = "ZXEQoUQSHgoZQ21kR3JpZEZpZ2h0TG9ja1Nob3BDc1JlcRDHRBITCg5DbWRK";
		buffer[17] = "Tk5OSkJBT0NPQhDVQxInCiJDbWRHcmlkRmlnaHRRdWl0TGVhdmVHYW1lUGxh";
		buffer[18] = "eUNzUmVxEIpCEhMKDkNtZE9LT0hFR0lCQ0NHEMRCEhMKDkNtZElOSERGRUlP";
		buffer[19] = "Qk5LENxCEhMKDkNtZEVHTkxDTkpETkNLEPdCEhwKF0NtZEdyaWRGaWdodEJ1";
		buffer[20] = "eUV4cENzUmVxEIREEiYKIUNtZEdyaWRGaWdodEVudGVyQmF0dGxlU3RhZ2VD";
		buffer[21] = "c1JlcRC7QhITCg5DbWRHRE1JSUJOSkpFShCjRBImCiFDbWRHcmlkRmlnaHRT";
		buffer[22] = "dW1tb25Qcm9qZWN0aW9uQ3NSZXEQ6EISKgolQ21kR3JpZEZpZ2h0U2VsZWN0";
		buffer[23] = "UmVjb21tZW5kRXF1aXBDc1JlcRDXQRITCg5DbWRDTUpDRUVEQ0lBThDSQxIm";
		buffer[24] = "CiFDbWRHcmlkRmlnaHRVcGRhdGVFcXVpcFRyYWNrU2NSc3AQ3UMSHwoaQ21k";
		buffer[25] = "R3JpZEZpZ2h0VXBkYXRlUG9zQ3NSZXEQ1UESEwoOQ21kRVBKSkJOUElGTEMQ";
		buffer[26] = "50ISEwoOQ21kQ0VGSU1BREJJQkgQ7EISEwoOQ21kUERPQ0pLQkpOSFAQwkIS";
		buffer[27] = "EwoOQ21kSFBNR0RGTUVJSkwQ4kISHAoXTEpLRUpMR0ROSkJfRkVKSkVBSUNF";
		buffer[28] = "Tk8QmkQSHwoaQ21kR3JpZEZpZ2h0VXBkYXRlUG9zU2NSc3AQgkMSJQogQ21k";
		buffer[29] = "R3JpZEZpZ2h0RW5kQmF0dGxlU3RhZ2VOb3RpZnkQwkQSEwoOQ21kTkxJRERL";
		buffer[30] = "SEpKRE8QmUQSJwoiQ21kR3JpZEZpZ2h0U2Vhc29uVGFsZW50UmVzZXRTY1Jz";
		buffer[31] = "cBDYQhITCg5DbWRESkNDQklPS05PRBDDQhITCg5DbWRGR0hIRElDTENKQhCZ";
		buffer[32] = "QhIkCh9DbWRHcmlkRmlnaHRSZXN1bWVHYW1lUGxheUNzUmVxELBEEhMKDkNt";
		buffer[33] = "ZE9MT0dJQUxPSkRQEPhDEhMKDkNtZENDTkxITExJQVBMEPlDEhMKDkNtZEdD";
		buffer[34] = "T0JFUE9HSFBMELNEEhoKFUNtZEZhdm91ckFyY2hpdmVTY1JzcBCJQxITCg5D";
		buffer[35] = "bWRFTUlEUENJSkFFThC+QxIcChdMSktFSkxHRE5KQl9OR0VOT05PT0VOQxC0";
		buffer[36] = "RBIgChtDbWRHcmlkRmlnaHRFcXVpcERyZXNzQ3NSZXEQtkQSEwoOQ21kSE5F";
		buffer[37] = "SkhBSkpJT0IQlUISKQokQ21kR3JpZEZpZ2h0SGFuZGxlUGVuZGluZ0FjdGlv";
		buffer[38] = "blNjUnNwEIpDEhMKDkNtZEFLSE9ESUlPR0RKEJJCEikKJENtZEdyaWRGaWdo";
		buffer[39] = "dFN5bmNVcGRhdGVSZXN1bHRTY05vdGlmeRCIQhITCg5DbWREQ0hPS0pBRktK";
		buffer[40] = "TxC6RBImCiFDbWRHcmlkRmlnaHRVcGRhdGVFcXVpcFRyYWNrQ3NSZXEQuEQS";
		buffer[41] = "LgopQ21kR3JpZEZpZ2h0VXBkYXRlRXF1aXBUcmFja1ByaW9yaXR5Q3NSZXEQ";
		buffer[42] = "3UISIQocQ21kR3JpZEZpZ2h0UmVmcmVzaFNob3BDc1JlcRDUQxITCg5DbWRP";
		buffer[43] = "TUpIUEhQUEFKSBC3RBIjCh5DbWRHcmlkRmlnaHRVc2VDb25zdW1hYmxlQ3NS";
		buffer[44] = "ZXEQgEMSIQocQ21kR3JpZEZpZ2h0UmVjeWNsZVJvbGVDc1JlcRDDQxIrCiZD";
		buffer[45] = "bWRHcmlkRmlnaHRQZXJtYW5lbnRUYWxlbnRFbmFibGVTY1JzcBD2QRIcChdM";
		buffer[46] = "SktFSkxHRE5KQl9IQ1BQSUJESE9PSBDgQRIjCh5DbWRHcmlkRmlnaHRTdGFy";
		buffer[47] = "dEdhbWVQbGF5Q3NSZXEQx0ISIAobQ21kR3JpZEZpZ2h0UXVpdFNldHRsZUNz";
		buffer[48] = "UmVxEKBCEhMKDkNtZENPQ0hGSEtLRUJOENxEEh0KGENtZEdyaWRGaWdodFNl";
		buffer[49] = "dHRsZU5vdGlmeRDBQhITCg5DbWRHUEhPREtDUENIRxDbQRIkCh9DbWRHcmlk";
		buffer[50] = "RmlnaHRGaW5pc2hUdXRvcmlhbENzUmVxEOxBEhwKF0xKS0VKTEdETkpCX0tO";
		buffer[51] = "QkFQS0tKT0RIEIBEEiYKIUNtZEdyaWRGaWdodEVudGVyQmF0dGxlU3RhZ2VT";
		buffer[52] = "Y1JzcBC5RBIcChdMSktFSkxHRE5KQl9QQklQTUdNQUJCThCDRBIoCiNDbWRH";
		buffer[53] = "cmlkRmlnaHRTZWFzb25UYWxlbnRFbmFibGVTY1JzcBCIRBITCg5DbWRESkNI";
		buffer[54] = "Q0hDQUpQQhC9QhIhChxDbWRHcmlkRmlnaHRCYWNrVG9QcmVwYXJlUmVxEOBE";
		buffer[55] = "EhMKDkNtZEhHT0lCREJNREJHEO5DEiUKIENtZEdyaWRGaWdodFN5bmNLZWVw";
		buffer[56] = "V2luQ250Tm90aWZ5EL9EEigKI0NtZEdyaWRGaWdodFNlYXNvblRhbGVudEVu";
		buffer[57] = "YWJsZUNzUmVxELBCEioKJUNtZEdyaWRGaWdodFBlcm1hbmVudFRhbGVudFJl";
		buffer[58] = "c2V0Q3NSZXEQpEMSKgolQ21kR3JpZEZpZ2h0UGVybWFuZW50VGFsZW50UmVz";
		buffer[59] = "ZXRTY1JzcBDpQRIeChlDbWRHcmlkRmlnaHRCdXlHb29kc0NzUmVxEIZDEhoK";
		buffer[60] = "FUNtZEZhdm91ckFyY2hpdmVDc1JlcRDSQhIeChlDbWRHcmlkRmlnaHRVc2VG";
		buffer[61] = "b3JnZUNzUmVxEO9BEicKIkNtZEdyaWRGaWdodFNlYXNvblRhbGVudFJlc2V0";
		buffer[62] = "Q3NSZXEQ80MSJgohQ21kR3JpZEZpZ2h0VGFrZVdlZWtseVJld2FyZENzUmVx";
		buffer[63] = "EJBDEhMKDkNtZENFSUlFSE5EUEFKENhEEiUKIENtZEdyaWRGaWdodFNlYXNv";
		buffer[64] = "bkhhbmRCb29rTm90aWZ5EJ1DEhMKDkNtZEtNREhMRU5MSU1GELFEEikKJENt";
		buffer[65] = "ZEdyaWRGaWdodERlc3Ryb3lXZWVrbHlSZXdhcmRDc1JlcRDZQhIdChhDbWRH";
		buffer[66] = "cmlkRmlnaHRHZXREYXRhQ3NSZXEQ90FCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[67] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdGridFightType) }, null, null));
	}
}
