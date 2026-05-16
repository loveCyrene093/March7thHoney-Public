using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdEvolveBuildTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdEvolveBuildTypeReflection()
	{
		_003C_003Ey__InlineArray21<string> buffer = default(_003C_003Ey__InlineArray21<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 0) = "ChhDbWRFdm9sdmVCdWlsZFR5cGUucHJvdG8q5gYKEkNtZEV2b2x2ZUJ1aWxk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 1) = "VHlwZRIbChdKREREUE5ERk5JSF9IT0pFRVBPRURIQxAAEiIKHUNtZEV2b2x2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 2) = "ZUJ1aWxkU3RhcnRMZXZlbFNjUnNwENc3EiYKIUNtZEV2b2x2ZUJ1aWxkU2tp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 3) = "cFRlYWNoTGV2ZWxTY1JzcBDFNxIcChdKREREUE5ERk5JSF9MRkhFQ1BFQUVE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 4) = "QxDrNxImCiFDbWRFdm9sdmVCdWlsZFNraXBUZWFjaExldmVsQ3NSZXEQ3TcS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 5) = "IgodQ21kRXZvbHZlQnVpbGRTdGFydFN0YWdlQ3NSZXEQ3zcSJwoiQ21kRXZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 6) = "bHZlQnVpbGRTaG9wQWJpbGl0eURvd25Dc1JlcRDMNxIlCiBDbWRFdm9sdmVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 7) = "dWlsZFNob3BBYmlsaXR5VXBDc1JlcRC/NxIrCiZDbWRHZXRFdm9sdmVCdWls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 8) = "ZFNob3BBYmlsaXR5UmVzZXRTY1JzcBDCNxIqCiVDbWRHZXRFdm9sdmVCdWls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 9) = "ZFNob3BBYmlsaXR5RG93blNjUnNwENs3EiAKG0NtZEdldEV2b2x2ZUJ1aWxk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 10) = "Q29pbk5vdGlmeRDWNxIiCh1DbWRFdm9sdmVCdWlsZFN0YXJ0TGV2ZWxDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 11) = "cRDaNxIoCiNDbWRHZXRFdm9sdmVCdWlsZFNob3BBYmlsaXR5VXBTY1JzcBDu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 12) = "NxIeChlDbWRFdm9sdmVCdWlsZEdpdmV1cENzUmVxEME3EiQKH0NtZEdldEV2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 13) = "b2x2ZUJ1aWxkUXVlcnlJbmZvU2NSc3AQwzcSIQocQ21kR2V0RXZvbHZlQnVp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 14) = "bGRHaXZldXBTY1JzcBC9NxIoCiNDbWRFdm9sdmVCdWlsZFNob3BBYmlsaXR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 15) = "UmVzZXRDc1JlcRDLNxIlCiBDbWRFdm9sdmVCdWlsZFJlUmFuZG9tU3RhZ2VD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 16) = "c1JlcRDoNxIkCh9DbWRHZXRFdm9sdmVCdWlsZEZpbmlzaFNjTm90aWZ5EL43";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 17) = "EhMKDkNtZFBDS05BSk9GR0xEEM83EiEKHENtZEV2b2x2ZUJ1aWxkUXVlcnlJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 18) = "bmZvQ3NSZXEQyTcSIgodQ21kRXZvbHZlQnVpbGRTdGFydFN0YWdlU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 19) = "4jcSKAojQ21kR2V0RXZvbHZlQnVpbGRSZVJhbmRvbVN0YWdlU2NSc3AQzjdC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 20) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray21<string>, string>(in buffer, 21))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdEvolveBuildType) }, null, null));
	}
}
