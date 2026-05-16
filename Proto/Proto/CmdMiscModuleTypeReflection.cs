using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMiscModuleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMiscModuleTypeReflection()
	{
		_003C_003Ey__InlineArray34<string> buffer = default(_003C_003Ey__InlineArray34<string>);
		buffer[0] = "ChdDbWRNaXNjTW9kdWxlVHlwZS5wcm90byquCwoRQ21kTWlzY01vZHVsZVR5";
		buffer[1] = "cGUSGwoXSEZGQkpPREhNRExfUENQREhFTFBLRU0QABITCg5DbWRCTVBPSE5D";
		buffer[2] = "TEhNRhCkIBITCg5DbWRDQklKSk5ER1BJThDOIBIeChlDbWRTdWJtaXRPcmln";
		buffer[3] = "YW1pSXRlbUNzUmVxEIggEh4KGUNtZERpcmVjdERlbGl2ZXJ5U2NOb3RpZnkQ";
		buffer[4] = "tyASKwomQ21kRGlmZmljdWx0eUFkanVzdG1lbnRVcGRhdGVEYXRhQ3NSZXEQ";
		buffer[5] = "zSASIgodQ21kU3dpdGNoTWFzY290VXBkYXRlU2NOb3RpZnkQ4SASHAoXSEZG";
		buffer[6] = "QkpPREhNRExfSEVFRVBJQUFFRkQQqyASJwoiQ21kQ2FuY2VsRGlyZWN0RGVs";
		buffer[7] = "aXZlcnlOb3RpY2VTY1JzcBC6IBInCiJDbWRDYW5jZWxEaXJlY3REZWxpdmVy";
		buffer[8] = "eU5vdGljZUNzUmVxEJ0gEh8KGkNtZEdldE1vdmllUmFjaW5nRGF0YUNzUmVx";
		buffer[9] = "EIsgEhMKDkNtZExCTVBQTEtFQkZPEIkgEiAKG0NtZEdldFN3aXRjaE1hc2Nv";
		buffer[10] = "dERhdGFTY1JzcBCYIBIfChpDbWRHZXRPcmlnYW1pUHJvcEluZm9Dc1JlcRDM";
		buffer[11] = "IBIjCh5DbWRHZXRXb2xmQnJvU2hvb3RpbmdEYXRhQ3NSZXEQ3SASIwoeQ21k";
		buffer[12] = "R2V0VW5yZWxlYXNlZEJsb2NrSW5mb0NzUmVxEIYgEisKJkNtZERpZmZpY3Vs";
		buffer[13] = "dHlBZGp1c3RtZW50VXBkYXRlRGF0YVNjUnNwELkgEigKI0NtZERpZmZpY3Vs";
		buffer[14] = "dHlBZGp1c3RtZW50R2V0RGF0YUNzUmVxEKAgEhMKDkNtZERQRkVOTkJPQk5E";
		buffer[15] = "EKIgEiMKHkNtZEdldFVucmVsZWFzZWRCbG9ja0luZm9TY1JzcBC1IBITCg5D";
		buffer[16] = "bWRMTUNFUElESEVCTBCFIBImCiFDbWRVcGRhdGVXb2xmQnJvU2hvb3RpbmdE";
		buffer[17] = "YXRhQ3NSZXEQvSASGQoUQ21kR2V0U2hhcmVEYXRhQ3NSZXEQ4iASJAofQ21k";
		buffer[18] = "Q3ljbGVTY29yZVJld2FyZEdldERhdGFDc1JlcRDGIBIbChZDbWRHZXRHdW5Q";
		buffer[19] = "bGF5RGF0YVNjUnNwEOQgEhMKDkNtZEtORENMSk5NQU9DEJIgEiIKHUNtZENh";
		buffer[20] = "bmNlbFN5bmNFeHBpcmVkSXRlbUNzUmVxEMMgEicKIkNtZEN5Y2xlU2NvcmVS";
		buffer[21] = "ZXdhcmRUYWtlUmV3YXJkQ3NSZXEQjyASEwoOQ21kSEZPREtNRkRNQUUQqSAS";
		buffer[22] = "IgodQ21kVXBkYXRlTW92aWVSYWNpbmdEYXRhU2NSc3AQ6CASEwoOQ21kTkZE";
		buffer[23] = "TExFUEhMSE4QqiASEgoNQ21kU2hhcmVTY1JzcBCOIBITCg5DbWRET0hKQ1BB";
		buffer[24] = "TUFGTBCoIBIfChpDbWRHZXRNb3ZpZVJhY2luZ0RhdGFTY1JzcBC+IBIgChtD";
		buffer[25] = "bWRHZXRTd2l0Y2hNYXNjb3REYXRhQ3NSZXEQ0yASGQoUQ21kR2V0U2hhcmVE";
		buffer[26] = "YXRhU2NSc3AQ4yASGwoWQ21kTWF6ZUtpbGxEaXJlY3RTY1JzcBCVIBIiCh1D";
		buffer[27] = "bWRVcGRhdGVNb3ZpZVJhY2luZ0RhdGFDc1JlcRCwIBITCg5DbWRBTERFSUJE";
		buffer[28] = "RE1PThCHIBITCg5DbWRFTUpNTEJETE1MQxCWIBIeChlDbWRVcGRhdGVHdW5Q";
		buffer[29] = "bGF5RGF0YVNjUnNwEJkgEhMKDkNtZExNSEZQRVBMSUtIEJ4gEjAKK0NtZEN5";
		buffer[30] = "Y2xlU2NvcmVSZXdhcmREZXN0cm95RXhjZWVkUmV3YXJkQ3NSZXEQyyASKAoj";
		buffer[31] = "Q21kRGlmZmljdWx0eUFkanVzdG1lbnRHZXREYXRhU2NSc3AQxSASGwoWQ21k";
		buffer[32] = "TWF6ZUtpbGxEaXJlY3RDc1JlcRCMIBISCg1DbWRTaGFyZUNzUmVxEN8gQhaq";
		buffer[33] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMiscModuleType) }, null, null));
	}
}
