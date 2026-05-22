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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 0) = "ChdDbWRNaXNjTW9kdWxlVHlwZS5wcm90byquCwoRQ21kTWlzY01vZHVsZVR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 1) = "cGUSGwoXSEZGQkpPREhNRExfUENQREhFTFBLRU0QABITCg5DbWRCTVBPSE5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 2) = "TEhNRhCkIBITCg5DbWRDQklKSk5ER1BJThDOIBIeChlDbWRTdWJtaXRPcmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 3) = "YW1pSXRlbUNzUmVxEIggEh4KGUNtZERpcmVjdERlbGl2ZXJ5U2NOb3RpZnkQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 4) = "tyASKwomQ21kRGlmZmljdWx0eUFkanVzdG1lbnRVcGRhdGVEYXRhQ3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 5) = "zSASIgodQ21kU3dpdGNoTWFzY290VXBkYXRlU2NOb3RpZnkQ4SASHAoXSEZG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 6) = "QkpPREhNRExfSEVFRVBJQUFFRkQQqyASJwoiQ21kQ2FuY2VsRGlyZWN0RGVs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 7) = "aXZlcnlOb3RpY2VTY1JzcBC6IBInCiJDbWRDYW5jZWxEaXJlY3REZWxpdmVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 8) = "eU5vdGljZUNzUmVxEJ0gEh8KGkNtZEdldE1vdmllUmFjaW5nRGF0YUNzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 9) = "EIsgEhMKDkNtZExCTVBQTEtFQkZPEIkgEiAKG0NtZEdldFN3aXRjaE1hc2Nv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 10) = "dERhdGFTY1JzcBCYIBIfChpDbWRHZXRPcmlnYW1pUHJvcEluZm9Dc1JlcRDM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 11) = "IBIjCh5DbWRHZXRXb2xmQnJvU2hvb3RpbmdEYXRhQ3NSZXEQ3SASIwoeQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 12) = "R2V0VW5yZWxlYXNlZEJsb2NrSW5mb0NzUmVxEIYgEisKJkNtZERpZmZpY3Vs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 13) = "dHlBZGp1c3RtZW50VXBkYXRlRGF0YVNjUnNwELkgEigKI0NtZERpZmZpY3Vs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 14) = "dHlBZGp1c3RtZW50R2V0RGF0YUNzUmVxEKAgEhMKDkNtZERQRkVOTkJPQk5E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 15) = "EKIgEiMKHkNtZEdldFVucmVsZWFzZWRCbG9ja0luZm9TY1JzcBC1IBITCg5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 16) = "bWRMTUNFUElESEVCTBCFIBImCiFDbWRVcGRhdGVXb2xmQnJvU2hvb3RpbmdE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 17) = "YXRhQ3NSZXEQvSASGQoUQ21kR2V0U2hhcmVEYXRhQ3NSZXEQ4iASJAofQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 18) = "Q3ljbGVTY29yZVJld2FyZEdldERhdGFDc1JlcRDGIBIbChZDbWRHZXRHdW5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 19) = "bGF5RGF0YVNjUnNwEOQgEhMKDkNtZEtORENMSk5NQU9DEJIgEiIKHUNtZENh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 20) = "bmNlbFN5bmNFeHBpcmVkSXRlbUNzUmVxEMMgEicKIkNtZEN5Y2xlU2NvcmVS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 21) = "ZXdhcmRUYWtlUmV3YXJkQ3NSZXEQjyASEwoOQ21kSEZPREtNRkRNQUUQqSAS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 22) = "IgodQ21kVXBkYXRlTW92aWVSYWNpbmdEYXRhU2NSc3AQ6CASEwoOQ21kTkZE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 23) = "TExFUEhMSE4QqiASEgoNQ21kU2hhcmVTY1JzcBCOIBITCg5DbWRET0hKQ1BB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 24) = "TUFGTBCoIBIfChpDbWRHZXRNb3ZpZVJhY2luZ0RhdGFTY1JzcBC+IBIgChtD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 25) = "bWRHZXRTd2l0Y2hNYXNjb3REYXRhQ3NSZXEQ0yASGQoUQ21kR2V0U2hhcmVE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 26) = "YXRhU2NSc3AQ4yASGwoWQ21kTWF6ZUtpbGxEaXJlY3RTY1JzcBCVIBIiCh1D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 27) = "bWRVcGRhdGVNb3ZpZVJhY2luZ0RhdGFDc1JlcRCwIBITCg5DbWRBTERFSUJE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 28) = "RE1PThCHIBITCg5DbWRFTUpNTEJETE1MQxCWIBIeChlDbWRVcGRhdGVHdW5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 29) = "bGF5RGF0YVNjUnNwEJkgEhMKDkNtZExNSEZQRVBMSUtIEJ4gEjAKK0NtZEN5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 30) = "Y2xlU2NvcmVSZXdhcmREZXN0cm95RXhjZWVkUmV3YXJkQ3NSZXEQyyASKAoj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 31) = "Q21kRGlmZmljdWx0eUFkanVzdG1lbnRHZXREYXRhU2NSc3AQxSASGwoWQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 32) = "TWF6ZUtpbGxEaXJlY3RDc1JlcRCMIBISCg1DbWRTaGFyZUNzUmVxEN8gQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 33) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray34<string>, string>(in buffer, 34))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMiscModuleType) }, null, null));
	}
}
